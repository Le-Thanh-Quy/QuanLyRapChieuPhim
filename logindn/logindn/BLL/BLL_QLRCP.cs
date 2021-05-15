using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using logindn.DTO;

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
        public List<CaChieu> GetCaChieus()
        {
            var l = db.CaChieux.Select(p => p);
            return l.ToList<CaChieu>();
        }
        public List<LoaiVe> GetLaoiVes()
        {
            var l = db.LoaiVes.Select(p => p);
            return l.ToList<LoaiVe>();
        }
        public List<PhongChieu> GetPhongChieus(int check)
        {
            if(check == 0)
            {
                var l = db.PhongChieux.Select(p => p);
                return l.ToList<PhongChieu>();
            }
            else
            {
                var l = db.PhongChieux.Where(p => p.TinhTrang == 1).Select(p => p);
                return l.ToList<PhongChieu>();
            }
            

        }
        public TaiKhoan GetTaiKhoan(string sdt)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            try
            {
                taiKhoan = db.TaiKhoans.Single(p => p.Phone == sdt);
            }
            catch
            {

            }
            return taiKhoan;
        }
        public List<LichChieu> GetLichChieus()
        {
            var l = db.LichChieux.Select(p => p);
            return l.ToList<LichChieu>();
        }
        public List<ViewThongKe> GetAllVes()
        {
            List<ViewThongKe> view = new List<ViewThongKe>();

            var l1 = db.Phims.Select(p => p);
            foreach (Phim o in l1.ToList<Phim>())
            {
                var l = db.Ves.Where(p => p.GheNgoi.LichChieu.idPhim == o.id).Select(p => p);
                ViewThongKe viewThongKe = new ViewThongKe();
                viewThongKe.TenPhim = o.TenPhim;
                int count = 0;
                double money = 0;
                foreach (Ve i in l.ToList<Ve>())
                {
                       
                    count++;
                    money += Convert.ToDouble(i.TienBanVe);
                }
                viewThongKe.TienBanVe = money.ToString() + " VND";
                viewThongKe.SoVeDaBan = count.ToString();
                view.Add(viewThongKe);
            }
            return view;
        }
        public List<ViewThongKe> GetVes(string idPhim, DateTime s, DateTime e)
        {
            List<ViewThongKe> view = new List<ViewThongKe>();
            for (DateTime dateTime = s; dateTime <= (e + TimeSpan.FromDays(1)); dateTime += TimeSpan.FromDays(1))
            {
                var l = db.Ves.Where(p => p.GheNgoi.LichChieu.idPhim == idPhim && p.GheNgoi.LichChieu.NgayChieu == dateTime).Select(p => p);
                ViewThongKe viewThongKe = new ViewThongKe();
                int count = 0;
                double money = 0;
                foreach (Ve i in l.ToList<Ve>())
                {
                    viewThongKe.TenPhim = i.GheNgoi.LichChieu.Phim.TenPhim;
                    viewThongKe.NgayChieu = i.GheNgoi.LichChieu.NgayChieu.Day.ToString() + "-" + i.GheNgoi.LichChieu.NgayChieu.Month.ToString() +"-"+ i.GheNgoi.LichChieu.NgayChieu.Year.ToString();
                    count++;
                    money +=  Convert.ToDouble(i.TienBanVe);
                }
                viewThongKe.TienBanVe = money.ToString() + " VND";
                viewThongKe.SoVeDaBan = count.ToString();
                if(count != 0)
                {
                    view.Add(viewThongKe);
                }
                
               
            }
            return view;
            
        }

        public List<ViewVe> GetVes(string id)
        {
            List<ViewVe> viewVes = new List<ViewVe>();
            if (id == "0")
            {
                DateTime dateTime = DateTime.Now.Date;
                var l = db.Ves.Where(p => p.idKhachHang != id && p.GheNgoi.LichChieu.NgayChieu == dateTime).Select(p => p);
                foreach (Ve i in l.ToList<Ve>())
                {
                    ViewVe viewVe = new ViewVe();
                    viewVe.id = i.id;
                    viewVe.Ghe = i.Ghe;
                    viewVe.Phim = i.GheNgoi.LichChieu.Phim.TenPhim;
                    viewVe.TenKhachHang = i.KhachHang.HoTen;
                    viewVe.SDT = i.KhachHang.SDT;
                    viewVe.TongTien = i.TienBanVe.ToString();
                    viewVe.NgayChieu = i.GheNgoi.LichChieu.NgayChieu.ToString();
                    viewVe.GioChieu = i.GheNgoi.LichChieu.CaChieu.ThoigianBatDau.ToString() + "-" + i.GheNgoi.LichChieu.CaChieu.ThoiGianKetThuc.ToString();
                    viewVes.Add(viewVe);
                }
            }
            else
            {
                var l = db.Ves.Where(p => p.idKhachHang == id).Select(p => p);
                foreach (Ve i in l.ToList<Ve>())
                {
                    ViewVe viewVe = new ViewVe();
                    viewVe.id = i.id;
                    viewVe.Ghe = i.Ghe;
                    if (i.GheNgoi == null)
                        continue;
                    viewVe.Phim = i.GheNgoi.LichChieu.Phim.TenPhim;
                    viewVe.TenKhachHang = i.KhachHang.HoTen;
                    viewVe.SDT = i.KhachHang.SDT;
                    viewVe.TongTien = i.TienBanVe.ToString();
                    viewVe.NgayChieu = i.GheNgoi.LichChieu.NgayChieu.ToString();
                    viewVe.GioChieu = i.GheNgoi.LichChieu.CaChieu.ThoigianBatDau.ToString() + "-" + i.GheNgoi.LichChieu.CaChieu.ThoiGianKetThuc.ToString();
                    viewVes.Add(viewVe);
                }
            }
            return viewVes;
        }
        public List<ViewPhongcs> GetGheNgois(string idphim, DateTime NgayChieu, string CaChieu)
        {
            var l = db.LichChieux.Where(p => p.idPhim == idphim && p.CaChieu.Tenca == CaChieu && p.NgayChieu == NgayChieu).Select(p => p);
            List<ViewPhongcs> viewPhongcs = new List<ViewPhongcs>();
            foreach (LichChieu i in l.ToList<LichChieu>())
            {
                GheNgoi gheNgoi = db.GheNgois.Single(p => p.idLichChieu == i.id);
                ViewPhongcs phongcs = new ViewPhongcs();
                phongcs.idGheNgoi = gheNgoi.idGheNgoi;
                phongcs.TenPhong = gheNgoi.LichChieu.PhongChieu.TenPhong;
                string length = "";
                if(gheNgoi.TrangThai == null)
                {
                    length = "0";
                }
                else
                {
                    length = (TachChuoi(gheNgoi.TrangThai).Length - 1).ToString();
                }
                phongcs.TrangThai =  length + "/" + gheNgoi.LichChieu.PhongChieu.SoChoNgoi;
                viewPhongcs.Add(phongcs);
            }
            return viewPhongcs;

        }
        public List<DateTime> GetLichChieuTheoNgays()
        {
            DateTime dateTime = DateTime.Now.Date;
            var l = db.LichChieux.Where(p => p.NgayChieu >= dateTime).Select(p => p.NgayChieu).Distinct();
            return l.ToList<DateTime>();
        }
        public KhachHang getInforUse(string Phone)
        {
            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            var l = db.KhachHangs.Where(p => p.SDT == Phone).Select(p => p);
            return l.ToArray<KhachHang>()[0];
        }
        

        public List<Phim> GetAllFilm(int check , DateTime dateTime)
        {
            if(check == 0)
            {
                var l = db.Phims.Select(p => p);
                return l.ToList<Phim>();
            }           
            else
            {
                
                var l1 = db.LichChieux.Where(p => p.NgayChieu == dateTime).Select(p => p);
                List<Phim> films = new List<Phim>();
                foreach (LichChieu i in l1.ToList<LichChieu>())
                {               
                        films.Add(i.Phim);
                }
                for(int i = 0; i < films.Count ; i++)
                {
                    for (int j = i + 1; j < films.Count; j++)
                        if (films[i].id == films[j].id)
                            films.RemoveAt(j);
                }
                return films;
                
            }
            
        }
        
        public List<Phim> GetListFilm(string theLoai, string ten , int check , DateTime dateTime)
        {
            if(check == 0)
            {
                if (theLoai == "")
                {
                    var l = db.Phims.Select(p => p);
                    List<Phim> films = new List<Phim>();
                    foreach (Phim i in l.ToList<Phim>())
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

                    var l = db.Phims.Where(p => p.TheLoai.TenTheLoai == theLoai).Select(p => p);
                    return l.ToList<Phim>();
                }
            }
            else
            {
                if (theLoai == "")
                {
                    
                    var l1 = db.LichChieux.Where(p => p.NgayChieu == dateTime).Select(p => p);


                    List<Phim> films = new List<Phim>();
                    foreach (LichChieu i in l1.ToList<LichChieu>())
                    {         
                        if (i.Phim.TenPhim.ToString().ToLower().Contains(ten.ToLower()))
                        {
                            films.Add(i.Phim);
                        }
                    }
                    for (int i = 0; i < films.Count; i++)
                    {
                        for (int j = i + 1; j < films.Count; j++)
                            if (films[i].id == films[j].id)
                                films.RemoveAt(j);
                    }
                    return films;
                }
                else
                {
                    DateTime data = DateTime.Now.Date;
                    var l1 = db.LichChieux.Where(p => p.NgayChieu == dateTime).Select(p => p);
                    List<Phim> films = new List<Phim>();
                    foreach (LichChieu i in l1.ToList<LichChieu>())
                    {
                        if (i.Phim.TheLoai.TenTheLoai == theLoai)
                        {
                            films.Add(i.Phim);
                        }
                    }
                    for (int i = 0; i < films.Count; i++)
                    {
                        for (int j = i + 1; j < films.Count; j++)
                            if (films[i].id == films[j].id)
                                films.RemoveAt(j);
                    }
                    return films;            
                }
            }
            
        }
        public Phim GetPhim(string id)
        {
            Phim phim = new Phim();
            try
            {
                 phim = db.Phims.Single(p => p.id == id);
            }
            catch
            {

            }
            return phim;
        }
        public Ve GetVe(string id)
        {
            Ve ve = new Ve();
            try
            {
                ve = db.Ves.Single(p => p.id == id);
            }
            catch
            {

            }
            return ve;
        }
        public KhachHang getKhachHang(string id)
        {
            KhachHang khachHang = new KhachHang();
            try
            {
                khachHang = db.KhachHangs.Single(p => p.id == id);
            }
            catch
            {

            }
            return khachHang;
            
        }
        public GheNgoi GetGheNgoi(string id)
        {
            GheNgoi gheNgoi = new GheNgoi();
            try
            {
                gheNgoi = db.GheNgois.Single(p => p.idGheNgoi == id);
            }
            catch
            {

            }
            return gheNgoi;
        }
        public PhongChieu GetPhong(string id)
        {
            PhongChieu phong = new PhongChieu();
            try
            {
                phong = db.PhongChieux.Single(p => p.id == id);
            }
            catch
            {

            }
            return phong;
        }
        
        public LichChieu GetLichChieu(string id)
        {
            LichChieu lichChieu = new LichChieu();
            try
            {
                lichChieu = db.LichChieux.Single(p => p.id == id);
            }
            catch
            {

            }
            return lichChieu;
        }
        public int GetTienVe(int id)
        {
            LoaiVe loaiVe = new LoaiVe();
            try
            {
                loaiVe = db.LoaiVes.Single(p => p.LoaiVe1 == id);
            }
            catch
            {

            }
            return Convert.ToInt32(loaiVe.Gia);
        }

        public CaChieu GetCaChieu(string id)
        {
            CaChieu cachieu = new CaChieu();
            try
            {
                cachieu = db.CaChieux.Single(p => p.id == id);
            }
            catch
            {

            }
            return cachieu;
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
     
        public int GetIdPhim()
        {
           
            int count = db.Phims.Select(p => p).Count();
            if (count == 0)
            {
                return 99;
            }
            var l = db.Phims.OrderByDescending(p => p.id).First();
            return Convert.ToInt32(l.id);
        }
        public int GetIdTheLoai()
        {

            int count = db.TheLoais.Select(p => p).Count();
            if (count == 0)
            {
                return 100;
            }
            var l = db.TheLoais.OrderByDescending(p => p.id).First();
            return Convert.ToInt32(l.id) + 1 ;
        } 
        public int GetIdGheNgoi()
        {

            int count = db.GheNgois.Select(p => p).Count();
            if (count == 0)
            {
                return 100;
            }
            var l = db.GheNgois.OrderByDescending(p => p.idGheNgoi).First();
            return Convert.ToInt32(l.idGheNgoi) + 1;
        }
        public int GetIdPhong()
        {

            int count = db.PhongChieux.Select(p => p).Count();
            if (count == 0)
            {
                return 100;
            }
            var l = db.PhongChieux.OrderByDescending(p => p.id).First();
            return Convert.ToInt32(l.id) + 1;
        }
        public int GetIdLichChieu()
        {

            int count = db.LichChieux.Select(p => p).Count();
            if (count == 0)
            {
                return 100;
            }
            var l = db.LichChieux.OrderByDescending(p => p.id).First();
            return Convert.ToInt32(l.id) + 1;
        }
        public int GetIdVe()
        {

            int count = db.Ves.Select(p => p).Count();
            if (count == 0)
            {
                return 100;
            }
            var l = db.Ves.OrderByDescending(p => p.id).First();
            return Convert.ToInt32(l.id) + 1;
        }
        public bool CheckPhim(Phim phim)
        {
            int count = db.Phims.Where(p => p.TenPhim == phim.TenPhim && p.HangPhim == phim.HangPhim && p.DaoDien == phim.DaoDien).Select(p => p).Count();
            if(count != 0)
            return true;
            return false;
        }
        public bool CheckLichChieu(LichChieu lichChieu)
        {
            int count = db.LichChieux.Where( p => p.NgayChieu == lichChieu.NgayChieu && p.idPhong == lichChieu.idPhong && p.idCaChieu == lichChieu.idCaChieu ).Select(p => p).Count();
            if (count != 0)
                return true;
            return false;
        }
        public void AddPhim(Phim phim)
        {

            db.Phims.Add(phim);
            db.SaveChanges();
        }
        public void AddPhong(PhongChieu phongChieu)
        {

            db.PhongChieux.Add(phongChieu);
            db.SaveChanges();
        }
        public void AddTheLoai(TheLoai theLoai)
        {

            db.TheLoais.Add(theLoai);
            db.SaveChanges();
        }
        public void AddVe(Ve ve)
        {

            db.Ves.Add(ve);
            db.SaveChanges();
        }
        public void AddLichChieu(LichChieu lichChieu)
        {
            db.LichChieux.Add(lichChieu);
            db.SaveChanges();
            GheNgoi gheNgoi = new GheNgoi();
            gheNgoi.idLichChieu = lichChieu.id;
            gheNgoi.idGheNgoi = BLL_QLRCP.Instance.GetIdGheNgoi().ToString();
            db.GheNgois.Add(gheNgoi);
            db.SaveChanges();
        }
        public void UpdateKhachHang(string id , int DiemTichLuy)
        {
            var result = db.KhachHangs.Where(b => b.id == id).FirstOrDefault();
            if (result != null)
            {
                result.DiemTichLuy = DiemTichLuy;
                db.SaveChanges();
            }
        }
        public void UpdatePhim(Phim phim)
        {
            var result = db.Phims.SingleOrDefault(b => b.id == phim.id);
            if (result != null)
            {
                result.HangPhim = phim.HangPhim;
                result.TenPhim= phim.TenPhim;
                result.DaoDien = phim.DaoDien;
                result.DienVien = phim.DienVien;
                if(phim.ApPhich != null)
                result.ApPhich = phim.ApPhich;
                result.ThoiLuong = phim.ThoiLuong;
                result.NgayCongChieu = phim.NgayCongChieu;
                result.idTheLoai = phim.idTheLoai;
                result.MoTa = phim.MoTa;
                result.Trailer = phim.Trailer;
                db.SaveChanges();
            }
        }
        public void UpdateLichChieu(LichChieu lich)
        {
            var result = db.LichChieux.SingleOrDefault(b => b.id == lich.id);
            if (result != null)
            {
                result.idPhong = lich.idPhong;
                result.idCaChieu = lich.idCaChieu;
                result.idPhim = lich.idPhim;
                result.NgayChieu = lich.NgayChieu.Date;
                db.SaveChanges();
            }
        }
        public void UpdateTheLoai(TheLoai theLoai)
        {
            var result = db.TheLoais.SingleOrDefault(b => b.id == theLoai.id);
            if (result != null)
            {
                result.TenTheLoai = theLoai.TenTheLoai;
                result.MoTa = theLoai.MoTa;
                db.SaveChanges();
            }
        }
        public void UpdateGiaVe(LoaiVe loaiVe)
        {
            var result = db.LoaiVes.SingleOrDefault(b => b.LoaiVe1 == loaiVe.LoaiVe1);
            if (result != null)
            {             
                result.Gia = loaiVe.Gia;
                db.SaveChanges();
            }
        }
        public void UpdatePhong(PhongChieu phongChieu)
        {
            var result = db.PhongChieux.SingleOrDefault(b => b.id == phongChieu.id);
            if (result != null)
            {
                result.TenPhong = phongChieu.TenPhong;
                result.SoChoNgoi = phongChieu.SoChoNgoi;
                result.TinhTrang = phongChieu.TinhTrang;          
                db.SaveChanges();
            }
        }
        public void DeletePhim(string idPhim)
        {
            var l = db.LichChieux.Where(p => p.idPhim == idPhim).Select(p => p);
            foreach (LichChieu i in l.ToList<LichChieu>())
            {
                GheNgoi lx = db.GheNgois.Single(p => p.idLichChieu == i.id);
                db.GheNgois.Remove(lx);
                db.SaveChanges();

                LichChieu lichChieu = db.LichChieux.Find(i.id);
                db.LichChieux.Remove(lichChieu);
                db.SaveChanges();
            }
            Phim phim = db.Phims.Find(idPhim);
            db.Phims.Remove(phim);
            db.SaveChanges();
            
                      
        }
        public void DeletePhong(string id)
        {
        
            PhongChieu phongChieu = db.PhongChieux.Find(id);
            db.PhongChieux.Remove(phongChieu);
            db.SaveChanges();
        }
        public void DeleteLichChieu(string id)
        {
            GheNgoi lx = db.GheNgois.Single(p => p.idLichChieu == id);
            db.GheNgois.Remove(lx);
            db.SaveChanges();
            LichChieu lichChieu = db.LichChieux.Find(id);
            db.LichChieux.Remove(lichChieu);
            db.SaveChanges();    
        }
        public string[] TachChuoi(string str)
        {        
            if(str == null)
            {
                return null;
            }
            string[] arrListStr = str.Split(' ');
            return arrListStr;
        }
        public void DeleteTheLoai(string id)
        {
            TheLoai theLoai = db.TheLoais.Find(id);
            db.TheLoais.Remove(theLoai);
            db.SaveChanges();
        }
        public void SetTrangThaiGheNgoi(GheNgoi gheNgoi)
        {
            var result = db.GheNgois.SingleOrDefault(b => b.idGheNgoi == gheNgoi.idGheNgoi);
            if (result != null)
            {            
                result.TrangThai = gheNgoi.TrangThai;
                db.SaveChanges();
            }
        }
    }
}
