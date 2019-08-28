using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WaterFallModelProject;
using WaterFallService.Admin;

namespace WaterFallApiProject.Controllers.Admin
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TestGroupingController : ApiController
    {
        AdminTestGroupingService service = new AdminTestGroupingService();

        //public AdminSampleController(AdminSampleService _service)
        //{  
        //    service = _service;
        //}
        public IHttpActionResult Get()
        {
            var data = service.GetAdminTestGroupingDetails();
            return Ok(data);
        }
        public IHttpActionResult Get(int Id)
        {
            var data = service.GetAdminTestGroupingDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult Put([FromBody] AdminTestGroupingModel model)
        {
            var data = service.AdminTestGroupingUpdate(model.TestGroupId, model);
            return Ok(data);
        }
        public IHttpActionResult Post([FromBody] AdminTestGroupingModel model)
        {
            var data = service.AdminTestGroupingInsert(model);
            return Ok(data);
        }
        public IHttpActionResult Delete(int Id)
        {
            var data = service.AdminTestGroupingRemove(Id);
            return Ok(data);
        }
    }
}