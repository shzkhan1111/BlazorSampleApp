using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace LoginBlazor
{
    public class LoginService
    {
        #region Property
        private readonly AppDbContext _appDBContext;
        #endregion

        #region Constructor
        public LoginService(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Employee> GetEmployeeeById(int Id)
        {
            Employee employee = await _appDBContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        #endregion
        #region Login
        public bool AuthUser(string userName , string Password)
        {
            //Employee employee = await _appDBContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            //return employee;
            bool isAuth = _appDBContext.Employees.Any(e => e.UserName == userName && e.Password == Password);
            return isAuth;
        }
        #endregion
    }
}
