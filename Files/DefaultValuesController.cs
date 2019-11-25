// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace BaseProject.API.Controllers
// {
//     [Route("api/[controller]")]
//     public class DefaultValuesController : ControllerBase
//     {
//         private object _application;

//         public DefaultValuesController(object application) {
//             _application = applicaion;
//         }

//         [HttpGet]
//         public async Task<ActionResult<IList<DefaultValue>>> GetAll() {
//             return await _application.GetAll();
//         }

//         [HttpGet]
//         public async Task<ActionResult<IList<DefaultValue>>> GetById(int id) {
//             return await _application.GetById(id);
//         }


//         [HttpPost]
//         public async Task<ActionResult> Create([FromBody]object defaultValue) { 
//             await _application.Create(defaultValue);
//             return Ok("Default Value Successfully Registered");
//         }

//         [HttpPut]
//         public async Task<ActionResult> Update([FromBody]object defaultValue) { 
//             await _application.Update(defaultValue);
//             return Ok("Default Value Successfully Registered");
//         }

//         [HttpDelete]
//         public async Task<ActionResult> Delete([FromBody]object defaultValue) { 
//             await _application.Delete(defaultValue);
//             return Ok("Default Value Successfully Registered");
//         }

//     }
// }