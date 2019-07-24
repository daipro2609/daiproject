using Hanback.DAL.EF;
using Hanback.Lib;
using Hanback.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanback.Service
{
    public class UserService : IUserService
    {
        private HanBackHomepageContext _context;

        public UserService(HanBackHomepageContext context)
        {
            _context = context;
        }

        public void CreateUser(HpMasUser user)
        {
            throw new NotImplementedException();
        }

        public  (bool status, string refMsg, HpMasUser user) Login(HpMasUser user)
        {
            string username = user.Username;
            string password = EncryptUtil.MD5(user.Password);

            var userValid = _context.HpMasUser.FirstOrDefault(u => u.Username == username && u.Password == password && u.UseYn == true);
            if (userValid != null)
            {
                userValid.Password = null;
                return (true, "Success", userValid);
            }


            return (false, "Not found user", null); 
        }

        public void UpdateUser(HpMasUser user)
        {
            throw new NotImplementedException();
        }
    }
}
