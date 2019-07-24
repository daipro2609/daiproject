using Hanback.DAL.EF;
using System.Threading.Tasks;

namespace Hanback.Service.IService
{
    public interface IUserService
    {
        void CreateUser(HpMasUser user);

        void UpdateUser(HpMasUser user);

        (bool status, string refMsg, HpMasUser user) Login(HpMasUser user);
    }
}
