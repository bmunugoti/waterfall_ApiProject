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
    public class AdminSampleController : ApiController
    {
        AdminSampleService service=new AdminSampleService();

        //public AdminSampleController(AdminSampleService _service)
        //{
        //    service = _service;
        //}
        public IHttpActionResult Get()
        {
            var data = service.GetAdminSampleDetails();
            return Ok(data);
        }
        public IHttpActionResult Get(int Id)
        {
            var data = service.GetAdminSampleDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult Put( [FromBody] AdminSampleModel model)
        {
            var data = service.AdminSampleUpdate(model.Id, model);
            return Ok(data);
        }
        public IHttpActionResult Post([FromBody] AdminSampleModel model)
        {
            var data = service.AdminSampleInsert(model);
            return Ok(data);
        }
        public IHttpActionResult Delete(int Id)
        {
            var data = service.AdminSampleRemove(Id);
            return Ok(data);
        }
    }
}