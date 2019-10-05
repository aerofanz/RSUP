using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Northwind.Model;
using Northwind.Repository_api;

namespace Northwind.Repository_service
{
    public class RoleRepository : IRoleRepository
    {
        private IDapperContext _context;

        public RoleRepository(IDapperContext context)
        {
            _context = context;
        }

        public int Delete(Role obj)
        {
            throw new System.NotImplementedException();
        }

        public IList<Role> GetAll()
        {
            var roles = _context.db.GetAll<Role>().ToList();
            return roles;
        }

        public int Save(Role obj)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Role obj)
        {
            throw new System.NotImplementedException();
        }
    }
}