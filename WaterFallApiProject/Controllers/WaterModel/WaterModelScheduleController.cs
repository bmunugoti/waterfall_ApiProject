using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WaterFallModelProject;
using WaterFallService.WaterModel;

namespace WaterFallApiProject.Controllers.WaterModel
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class WaterModelScheduleController : ApiController
    {
        WaterModelScheculeService service = new WaterModelScheculeService();

        //public AdminSampleController(AdminSampleService _service)
        //{  
        //    service = _service;
        //}
        public IHttpActionResult Get()
        {
            var data = service.GetWaterModelScheduleDetails();
            return Ok(data);
        }
        public IHttpActionResult Get(int Id)
        {
            var data = service.GetWaterModelScheduleDetailsById(Id);
            return Ok(data);
        }
        public IHttpActionResult Put([FromBody] ScheduleModel model)
        {
            var data = service.WaterModelScheduleUpdate(model.ScheduleId, model);
            return Ok(data);
        }
        public IHttpActionResult Post([FromBody] List<ScheduleModel> model)
        {
            var data = service.WaterModelScheduleInsert(model);
            return Ok(data);
        }
        public IHttpActionResult Delete(int Id)
        {
            var data = service.WaterModelScheduleRemove(Id);
            return Ok(data);
        }
    }
}