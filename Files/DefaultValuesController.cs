// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace BaseProject.API.Controllers
// {
//     [Route("api/[controller]")]
//     public class DefaultValuesController : ControllerBase
//     {
//         private IDefaultValueApplication _application;

//         public DefaultValuesController(IDefaultValueApplication application) {
//             _application = applicaion;
//         }

//         [HttpGet]
//         public async Task<ActionResult<IList<DefaultValue>>> GetAll() {
//             return await _application.GetAll();
//         }

//         [HttpPost]
//         public async Task<ActionResult> Create([FromBody]DefaultValue defaultValue) { 
//             await _application.Create(defaultValue);
//             return Ok("Default Value Successfully Registered");
//         }

//     }
// }