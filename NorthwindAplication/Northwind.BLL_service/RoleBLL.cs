using Northwind.BLL_api;
using Northwind.Model;
using Northwind.Repository_service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL_service
{
    public class RoleBLL : IRoleBLL
    {
        private DapperContext _context;
        private UnitOfWork _uow;

        public RoleBLL()
        {
            _context = new DapperContext();
            _uow = new UnitOfWork(_context);
        }
        public int Delete(Role obj)
        {
            throw new NotImplementedException();
        }

        public IList<Role> GetAll()
        {
            var roles = _uow.RoleRepository.GetAll();
            return roles;
        }

        public int Save(Role obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Role obj)
        {
            throw new NotImplementedException();
        }
    }
}
