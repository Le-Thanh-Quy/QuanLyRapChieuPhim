using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace logindn.BLL
{
    class BLL_QLRCP
    {
        private QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
        
        
        private static BLL_QLRCP _Instance;

        public static BLL_QLRCP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLRCP();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private BLL_QLRCP()
        {

        }

        public List<TheLoai> GetListGenre()
        {
            var l = db.TheLoais.Select(p => p);
            return l.ToList<TheLoai>();
        }

        public KhachHang getInforUse(string Phone)
        {
            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            var l = db.KhachHangs.Where(p => p.SDT == Phone).Select(p => p);
            return l.ToArray<KhachHang>()[0];
        }

        public List<Phim> GetAllFilm()
        {
            var l = db.Phims.Where(p => p.TrangThai == true).Select(p => p);
            return l.ToList<Phim>();
        }

        public List<Phim> GetListFilm(string theLoai, string ten)
        {
            if (theLoai == "")
            {
                var l = db.Phims.Where(p => p.TrangThai == true).Select(p => p);
                List<Phim> films = new List<Phim>();
                foreach(Phim i in l.ToList<Phim>())
                {
                    if (i.TenPhim.ToString().ToLower().Contains(ten.ToLower()))
                    {
                        films.Add(i);
                    }
                }
                return films;
            }
            else
            {

                var l = db.Phims.Where(p => p.TheLoai.TenTheLoai == theLoai &&  p.TrangThai == true).Select(p => p);
                return l.ToList<Phim>();
            }
        }
        public Phim GetPhim(string id)
        {
            Phim phim = db.Phims.Single(p => p.id == id);
            return phim;
        }
        public byte[] ConvertFilltoByte (string str)
        {
            byte[] data = null;
            FileInfo fileInfo = new FileInfo(str);
            long numBytes = fileInfo.Length;
            FileStream fileStream = new FileStream(str , FileMode.Open , FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            data = binaryReader.ReadBytes((int)numBytes);
            return data;
        }

        public Image ConvertByteyoImage(byte[] photo)
        {
            Image image;
            using (MemoryStream memoryStream = new MemoryStream(photo, 0, photo.Length))
            {
                memoryStream.Write(photo, 0, photo.Length);
                image = Image.FromStream(memoryStream, true);
            }
            return image;
        }
    }
}
