using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WaterFallModelProject;
using WaterFallService.Admin;

namespace WaterFallApiProject.Controllers.Admin
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminIncubatorController : ApiController
    {
        AdminIncubatorService service=new AdminIncubatorService();

        //public AdminIncubatorController(AdminIncubatorService _service)
        //{
        //    service = _service;
        //}
       // [Route("api/GetIncubator")]
       // [HttpGet]
        public IHttpActionResult Get()
        {
            var data = service.GetAdminIncubatorDetails();
            return Ok(data);
        }
        public IHttpActionResult Get(int Id)
        {
            var data = service.GetAdminIncubatorDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult Put( [FromBody] AdminIncubatorModel model)
        {
            var data = service.AdminIncubatorUpdate(model.IncubatorId, model);
            return Ok(data);
        }
        public IHttpActionResult Post([FromBody] AdminIncubatorModel model)
        {
            var data = service.AdminIncubatorIndert(model);
            return Ok(data);
        }
        public IHttpActionResult Delete(int Id)
        {
            var data = service.AdminIncubatorRemove(Id);
            return Ok(data);
        }

    }
}