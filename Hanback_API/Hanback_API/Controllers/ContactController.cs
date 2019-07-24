using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using Hanback.DAL.Data;
using Hanback.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Hanback_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService _contactService;

        public ContactController(IContactService contact)
        {
            _contactService = contact;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<HanContact>> Get()
        {
            var data = _contactService.GetAll();
            return data.ToArray();
        }
         
        // PUT api/values/5
         [HttpPost]
        public async Task<ActionResult> Post([FromBody] HanContact obj)
        {
            var data = await _contactService.Update(obj.Id);
            if (!data.status)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("pushmessage")]
        public async Task<ActionResult> PushMessage([FromBody] HanContact obj)
        {
            var data = await _contactService.PushMessage(obj);
            if (!data.status)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }



    }
}
