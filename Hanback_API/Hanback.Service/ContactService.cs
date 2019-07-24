using Hanback.DAL.Data;
using Hanback.DAL.EF;
using Hanback.Service.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Hanback.Service.CFMPush;

namespace Hanback.Service
{

    public class ContactService : IContactService
    {
        private readonly ILogger _logger;
        private IPushService _iPushService;
        private HanBackHomepageContext _context;
        public ContactService(HanBackHomepageContext context, ILogger<HanContact> logger, IPushService iPushService)
        {
            _context = context;
            _logger = logger;
            _iPushService = iPushService;
        }

        public IEnumerable<HanContact> GetAll()
        {
            var lst = from f in _context.HpTnsFeedback
                      orderby f.CreateTime descending
                      select new HanContact
                      {
                          Id = f.Id
                      ,
                          Remark = f.Remark
                      ,
                          REPLY_YN = f.ReplyYn
                      ,
                          Email = f.Email
                      ,
                          Name = f.Name
                      ,
                          Message = f.Message
                      ,
                          Phone = f.Phone
                      ,
                          Created_time = f.CreateTime
                      ,                       
                          Category = f.Category
                      };
            return lst;
        }

        public async Task<(bool status, string refMsg)> PushMessage([FromBody] HanContact contact)
        {
            await _iPushService.PushArticleToTopicAsync("customer_contact", contact);
            return (true, "Success");
        }

        public async Task<(bool status, string refMsg)> Update(int id)
        {
            try
            {
                var info = await _context.HpTnsFeedback.FirstOrDefaultAsync(
                    c => c.Id == id);

                if (info == null)
                {
                    return (false, "info not found");
                }
                info.ReplyYn = true;
                info.ReplyTime = DateTime.Now;
                _context.HpTnsFeedback.Update(info);
                await _context.SaveChangesAsync();
                return (true, "Success");


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Update Info Error");
                return (false, ex.Message);
            }
        }
    }
}
