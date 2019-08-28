using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WaterFallModelProject;
using WaterFallService.Admin;

namespace WaterFallApiProject.Controllers.Admin
{
    public class AdminMasterController : ApiController
    {
        AdminMasterService service;

        public AdminMasterController(AdminMasterService _service)
        {
            service = _service;
        }
        public IHttpActionResult Get()
        {
            var data = service.GetAdminMaterDetails();
            return Ok(data);
        }
        public IHttpActionResult GetById(int Id)
        {
            var data = service.GetAdminMaterDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult AdminMasterUpdate(int Id,[FromBody] AdminModel model)
        {
            var data = service.AdminUpdate(Id,model);
            return Ok(data);
        }
        public IHttpActionResult AdminMasterInsert( [FromBody] AdminModel model)
        {
            var data = service.AdminIndert( model);
            return Ok(data);
        }
        public IHttpActionResult AdminMasterDelete(int Id)
        {
            var data = service.AdminRemove(Id);
            return Ok(data);
        }
    }
}