using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1712534
{
    class NhanVienController
    {
        private NhanVienService nvService = new NhanVienService();
        public DataTable getAll()
        {
            return nvService.getAll();
        }

        public string login()
        {
            return nvService.login();
        }

        public bool insert()
        {
            return nvService.insert();
        }
    }
}
