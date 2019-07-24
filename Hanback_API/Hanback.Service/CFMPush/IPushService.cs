using Hanback.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hanback.Service.CFMPush
{

    public interface IPushService
    {
        Task<string> PushArticleToTopicAsync(string article, HanContact contact);


    }

}
