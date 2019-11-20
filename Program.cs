using System;
using System.Collections.Generic;
using System.IO;

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

                var path = string.Concat("./Controllers/", args[0], "Controller", ".cs");
                Console.WriteLine(path);

                FileStream fileStream = null;
                using(fileStream = File.Create(path)) { }

                using (StreamWriter writer = new StreamWriter(path))  
                {  
                    foreach(var line in ClassText()) {
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
            lines.Add("using Microsoft.AspNetCore.Mvc;");
            lines.Add("");
            lines.Add("namespace DefaultProject.API.Controllers");
            lines.Add("{");
            lines.Add("");
            lines.Add("     [Route(\"api/[controller]\")]");
            lines.Add("     [public class DefaultValuesController : ControllerBase");
            lines.Add("     {");
            lines.Add("         private IDefaultValueApplication _application;");
            lines.Add("");
            lines.Add("         public DefaultValuesController(IDefaultValueApplication application) {");
            lines.Add("             _application = applicaion;");
            lines.Add("         }");
            lines.Add("");
            lines.Add("         [HttpGet]");
            lines.Add("         public async Task<ActionResult<IList<DefaultValue>>> GetAll() {");
            lines.Add("             return await _application.GetAll();");
            lines.Add("         }");
            lines.Add("");
            lines.Add("         [HttpPost]");
            lines.Add("         public async Task<ActionResult> Create([FromBody]DefaultValue defaultValue) {");
            lines.Add("             return await _application.GetAll();");
            lines.Add("             return Ok(\"Default Value Successfully Registered\")");
            lines.Add("         }");
            lines.Add("     }");
            lines.Add("}");
            return lines;
        }
    }
}
