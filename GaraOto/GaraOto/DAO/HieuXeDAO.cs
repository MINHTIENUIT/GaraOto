using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraOto.DAO
{
    class HieuXeDAO
    {
        private static HieuXeDAO instance;

        internal static HieuXeDAO Instance
        {
            get
            {
                if (instance == null) instance = new HieuXeDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public DataTable getListHieuXe() {
            string query = "GETLISTHIEUXE";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable addHieuXe(string hx) {
            string query = "THEMHIEUXE @HIEUXE";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { hx });
        }

        public void delHieuXe(string hx) {
            string query = "XOAHIEUXE @HIEUXE";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { hx });
        }
    }
}
