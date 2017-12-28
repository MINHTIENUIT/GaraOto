using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GaraOto.DTO
{
    class XeCtrl
    {
        public static DataSet FillDataset_getXeByIdXe(string _idXe)
        {
            try
            {
                DAO.XeMod xe = new DAO.XeMod(_idXe);
                return xe.FillDataSet_getXeByIdXe();
            }
            catch
            {
                return null;
            }
        }
        public static int InsertXe(string _BienSo, string _HieuXe, string _TenChuXe, string _DienThoai, string _DiaChi, string _Email, DateTime _NgayTiepNhan)
        {
            try
            {
                DAO.XeMod _xe = new DAO.XeMod(_BienSo, _HieuXe, _TenChuXe, _DienThoai, _DiaChi, _Email, _NgayTiepNhan);
                return _xe.InsertXe();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateXe(string _BienSo, string _HieuXe, string _TenChuXe, string _DienThoai, string _DiaChi, string _Email, DateTime _NgayTiepNhan)
        {
            try
            {
                DAO.XeMod _xe = new DAO.XeMod(_BienSo, _HieuXe, _TenChuXe, _DienThoai, _DiaChi, _Email, _NgayTiepNhan);
                return _xe.UpdateXe();
            }
            catch
            {
                return 0;
            }
        }

        public static int DeleteXe(string _idXe)
        {
            try
            {
                DAO.XeMod _xe = new DAO.XeMod(_idXe);
                return _xe.DeleteXe();
            }
            catch
            {
                return 0;
            }
        }

        public static DataSet FillDataSet_SearchXeByIdXe(string _IdXe)
        {
            try
            {
                DAO.XeMod xe = new DAO.XeMod(_IdXe);
                return xe.FillDataSet_getXeByIdXe();
            }
            catch
            {
                return null;
            }
        }

        public static DataSet FillDataSet_SearchXeByTenChuXe(string _TenChuXe)
        {
            try
            {
                DAO.XeMod xe = new DAO.XeMod(_TenChuXe);
                return xe.FillDataSet_SearchXeByTenChuXe();
            }
            catch
            {
                return null;
            }
        }
    }
}
