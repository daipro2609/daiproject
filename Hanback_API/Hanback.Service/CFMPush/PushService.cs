using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hanback.DAL.Data;
using Microsoft.Extensions.Logging;

namespace Hanback.Service.CFMPush
{
    public class PushService : IPushService
    {
        private GoogleCloudMessagingService _ggService;
        //private readonly IDbConnection _dbConnection;
        private readonly ILogger _logger;

        public PushService(ILogger<PushService> logger)
        {
            _ggService = new GoogleCloudMessagingService();
        }

        public async Task<string> PushArticleToTopicAsync(string article, HanContact contact)
        {
            try
            { 
                var title = string.Concat(contact.Email," -> ", contact.Name) ;
                var body = contact.Message;
                return await _ggService.SendTopicMessage(article, title , body);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PushArticleToTopic");
                return ex.Message;
            }
        }
    }
}
