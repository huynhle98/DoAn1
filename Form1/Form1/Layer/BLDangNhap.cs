using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Form1.Layer
{
    class BLDangNhap
    {
        public bool KiemTra(string TenDN, string MK, ref string err)
        {
            GameStackEntities1 tk = new GameStackEntities1();
            var f = (from dn in tk.TaiKhoans
                     where dn.TenTK == TenDN
                     select dn).SingleOrDefault();
            if (f != null)
            {
                if (f.MatKhau == MK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        
        }
        public bool KiemtraTK(string TenDN, string SoDT, ref string err)
        {
            GameStackEntities1 GS = new GameStackEntities1();
            var t = (from mk in GS.TaiKhoans
                     where mk.TenTK == TenDN
                     select mk).SingleOrDefault();
            if (t != null)
            {
                if (t.SDT == SoDT)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int KiemtraTKDK(string TenDN, string TenNV, ref string err)
        {
            GameStackEntities1 GS = new GameStackEntities1();
            var t = (from mk in GS.TaiKhoans
                     where mk.TenTK == TenDN
                     select mk).SingleOrDefault();
            if (t != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            var t2 = (from mk in GS.TaiKhoans
                     where mk.TenNV == TenNV
                     select mk).SingleOrDefault();
            if (t != null)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public bool LayMK(string TenDN, string MK, ref string err)
        {
            GameStackEntities1 gs = new GameStackEntities1();
            var t = (from mk in gs.TaiKhoans
                     where mk.TenTK == TenDN
                     select mk).SingleOrDefault();
            if (t != null)
            {
                t.MatKhau = MK;
                gs.SaveChanges();
            }
            return true;
        }
        public void ThemTK(string TenTK, string TenNV, string MK, string SDT, ref string err)
        {
            GameStackEntities1 gs = new GameStackEntities1();
            TaiKhoan tk = new TaiKhoan();
            BoSuuTapCaNhan Bst = new BoSuuTapCaNhan();
            BangXH bxh = new BangXH();
            int id = 0;

            var sotk = from t in gs.TaiKhoans
                       select t;
            foreach(var t in sotk)
            {
                id++;
            }
            id++;
            tk.TenTK = TenTK;
            tk.TenNV = TenNV;
            tk.MatKhau = MK;
            tk.SDT = SDT;
            tk.ID =id;
            Bst.TenTK = TenTK;
            Bst.ID = id;
            bxh.TenTK = TenTK;
            bxh.TenNV = TenNV;

            gs.TaiKhoans.Add(tk);
            gs.BoSuuTapCaNhans.Add(Bst);
            gs.BangXHs.Add(bxh);
            gs.SaveChanges();

        }
    }
}
