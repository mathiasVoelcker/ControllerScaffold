using System;
using System.Collections.Generic;
using System.IO;
using Extensions.MV;

namespace DefaultApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try {
                Console.WriteLine("Hello World!");
                
                if (!Directory.Exists("./Controllers")) {
                    Directory.CreateDirectory("./Controllers");
                }

                Console.WriteLine(Directory.GetCurrentDirectory());

                var controllerName = args[0];

                var path = string.Concat("./Controllers/", args[0], "Controller", ".cs");
                Console.WriteLine(path);

                FileStream fileStream = null;
                using(fileStream = File.Create(path)) { }

                using (StreamWriter writer = new StreamWriter(path))  
                {  
                    foreach(var line in ClassText()) {
                        if (!string.IsNullOrEmpty(controllerName)) {
                            var newLine = line.Replace("Default", controllerName.Capitalize());
                            newLine = newLine.Replace("default", controllerName.ToLower());
                            writer.WriteLine(newLine);
                        }     
                        else 
                            writer.WriteLine(line);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        
        }

        public static List<string> ClassText() {
            List<string> lines = new List<string>();
//            using Microsoft.AspNetCore.Mvc;
//     using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
            lines.Add("using Microsoft.AspNetCore.Mvc;");
            lines.Add("using System.Collections.Generic;");
            lines.Add("using System.Threading.Tasks;");
            lines.Add("");
            lines.Add("namespace DefaultProject.API.Controllers");
            lines.Add("{");
            lines.Add("");
            lines.Add("     [Route(\"api/[controller]\")]");
            lines.Add("     public class DefaultController : ControllerBase");
            lines.Add("     {");
            lines.Add("         private IDefaultApplication _application;");
            lines.Add("");
            lines.Add("         public DefaultController(DefaultApplication application) {");
            lines.Add("             _application = application;");
            lines.Add("         }");
            lines.Add("");
            lines.Add("         [HttpGet]");
            lines.Add("         public async Task<ActionResult<IList<Default>>> GetAll() {");
            lines.Add("             return await _application.GetAll();");
            lines.Add("         }");
            lines.Add("");
            lines.Add("         [HttpGet]");
            lines.Add("         public async Task<ActionResult<IList<Default>>> GetById() {");
            lines.Add("             return await _application.GetById();");
            lines.Add("         }");
            lines.Add("");        
            lines.Add("         [HttpPost]");
            lines.Add("         public async Task<ActionResult> Create([FromBody]Default default) {");
            lines.Add("             await _application.Create();");
            lines.Add("             return Ok(\"Default Successfully Registered\");");
            lines.Add("         }");
            lines.Add("");        
            lines.Add("         [HttpPut]");
            lines.Add("         public async Task<ActionResult> Update([FromBody]Default default) {");
            lines.Add("             await _application.Update();");
            lines.Add("             return Ok(\"Default Successfully Updated\");");
            lines.Add("         }");
            lines.Add("");        
            lines.Add("         [HttpDelete]");
            lines.Add("         public async Task<ActionResult> Delete([FromBody]int id) {");
            lines.Add("             await _application.Delete();");
            lines.Add("             return Ok(\"Default Successfully Deleted\");");
            lines.Add("         }");
            lines.Add("     }");
            lines.Add("}");
            return lines;
        }
    }
}
