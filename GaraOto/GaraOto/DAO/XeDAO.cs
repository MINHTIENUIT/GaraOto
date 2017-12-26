using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraOto.DAO
{
    class XeDAO
    {
        private static XeDAO instance;

        internal static XeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new XeDAO();
                }
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        private XeDAO() { }

        public DataTable getListXeByBienSo(string bienSo)
        {
            string querySTR = "GetListXeByBienSo @BienSo";
            return DataProvider.Instance.ExecuteQuery(querySTR, new object[] { bienSo });
        }

        public DataTable getListXeByChuXe(string name)
        {
            string querySTR = "GetListXeByBienSo @TENCHUXE";
            return DataProvider.Instance.ExecuteQuery(querySTR, new object[] { name });
        }
    }


}
