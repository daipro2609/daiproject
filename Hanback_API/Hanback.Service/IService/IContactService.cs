using Hanback.DAL.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hanback.Service.IService
{
    public interface IContactService
    {
        Task<(bool status, string refMsg)> Update(int id);

        IEnumerable<HanContact> GetAll();

        Task<(bool status, string refMsg)> PushMessage([FromBody] HanContact contact);
    }
}
