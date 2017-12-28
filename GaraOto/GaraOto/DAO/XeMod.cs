using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GaraOto.DAO
{
    class XeMod
    {
        protected string BienSo { get; set; }
        protected string HieuXe { get; set; }
        protected string TenChuXe { get; set; }
        protected string DienThoai { get; set; }
        protected string DiaChi { get; set; }
        protected string Email { get; set; }
        protected DateTime NgayTiepNhan { get; set; }

        public XeMod(string _BienSo)
        {
            BienSo = _BienSo;
        }

        public XeMod() { }

        public XeMod(string _BienSo, string _HieuXe, string _TenChuXe, string _DienThoai, string _DiaChi, string _Email, DateTime _NgayTiepNhan)
        {
            BienSo = _BienSo;
            HieuXe = _HieuXe;
            TenChuXe = _TenChuXe;
            DienThoai = _DienThoai;
            DiaChi = _DiaChi;
            Email = _Email;
            NgayTiepNhan = _NgayTiepNhan;
        }

        public int InsertXe()
        {
<<<<<<< HEAD
            object[] values = new object[7] { BienSo, TenChuXe, HieuXe, DiaChi,  DienThoai , Email,NgayTiepNhan };
            string querry = "THEMXE @BIENSO , @TENCX , @HIEUXE , @DIACHI , @DIENTHOAI , @EMAIL , @NGAYTN";
            DataTable numrow = DAO.DataProvider.Instance.ExecuteQuery(querry, values);
            return(int)numrow.Rows[0].ItemArray[0];
=======
            int i = 0;
            string[] paras = new string[7] { "@BIENSO", "@TENCX", "@HIEUXE", "@DIACHI", "@DIENTHOAI", "@EMAIL", "@NGAYTN" };
            object[] values = new object[7] { BienSo, TenChuXe, HieuXe, DiaChi, DienThoai, Email, NgayTiepNhan };
            i = DAO.conection.Excute_Sql("THEMXE", CommandType.StoredProcedure, paras, values);
            return i;
>>>>>>> be6d162fb47bea76a99a489f3707ce215245c5a2
        }

        public int UpdateXe()
        {
<<<<<<< HEAD
            object[] values = new object[7] { BienSo, TenChuXe, HieuXe, DiaChi, DienThoai, Email, NgayTiepNhan };
            string querry = "SUATTXE @BIENSO , @TENCX , @DIACHI , @DIENTHOAI , @EMAIL";
            DataTable numrow = DAO.DataProvider.Instance.ExecuteQuery(querry, values);
            return (int)numrow.Rows[0].ItemArray[0];
=======
            int i = 0;
            string[] paras = new string[5] { "@BIENSO", "@TENCX", "@DIACHI", "@DIENTHOAI", "@EMAIL" };
            object[] values = new object[5] { BienSo, TenChuXe, DiaChi, DienThoai, Email };
            i = DAO.conection.Excute_Sql("SUATTXE", CommandType.StoredProcedure, paras, values);
            return i;
>>>>>>> be6d162fb47bea76a99a489f3707ce215245c5a2
        }

        public int DeleteXe()
        {
<<<<<<< HEAD
            object[] values = new object[1] {BienSo};
            string querry = "XOAXE @BIENSO";
            DataTable numrow = DAO.DataProvider.Instance.ExecuteQuery(querry, values);
            return (int)numrow.Rows[0].ItemArray[0];
=======
            int i = 0;
            string[] paras = new string[1] { "@BIENSO" };
            object[] values = new object[1] { BienSo };
            i = DAO.conection.Excute_Sql("XOAXE", CommandType.StoredProcedure, paras, values);
            return i;
>>>>>>> be6d162fb47bea76a99a489f3707ce215245c5a2
        }

        public static DataSet FillDataSetXe()
        {
            return DAO.conection.FillDataSet("GETLISTXE", CommandType.StoredProcedure);
        }

        public DataSet FillDataSet_getXeByIdXe()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@BIENSO" };
            object[] values = new object[1] { BienSo };
            ds = DAO.conection.FillDataSet("spgetXeByBienSo", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDataSet_SearchXeByIdXe()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@BIENSO" };
            object[] values = new object[1] { BienSo };
            ds = DAO.conection.FillDataSet("GetListXeByBienSo", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public DataSet FillDataSet_SearchXeByTenChuXe()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TENCHUXE" };
            object[] values = new object[1] { BienSo };
            ds = DAO.conection.FillDataSet("GetListXeByChuXe", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
