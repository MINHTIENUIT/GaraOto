using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraOto.DAO
{
    class PhieuThuTienDAO
    {
        static PhieuThuTienDAO instance;

        internal static PhieuThuTienDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        private PhieuThuTienDAO() { }

        public DataTable GetListPhieuThuTienByBS(string bs)
        {
            String querySTR = "GETPTT @BIENSO";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(querySTR,new object[] { bs });
            return data;
        }
    }
}
