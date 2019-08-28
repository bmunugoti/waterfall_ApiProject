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
    public class AdminChemicalTestController : ApiController
    {
        AdminChemicalTestService service=new AdminChemicalTestService();

        //public AdminChemicalTestController(AdminChemicalTestService _service)
        //{
        //    service = _service;
        //}
        public IHttpActionResult Get()
        {
            var data = service.GetAdminTestDetails();
            return Ok(data);
        }
       
        public IHttpActionResult Get(int Id)
        {
            var data = service.GetAdminTestDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult Put( [FromBody] AdminChemicalTestModel model)
        {
            var data = service.AdminTestUpdate(model.Id, model);
            return Ok(data);
        }
        public IHttpActionResult Post([FromBody] AdminChemicalTestModel model)
        {
            var data = service.AdminTestInsert(model);
            return Ok(data);
        }
        public IHttpActionResult Delete(int Id)
        {
            var data = service.AdminTestRemove(Id);
            return Ok(data);
        }

    }
}