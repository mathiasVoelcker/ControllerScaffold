using System;
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

                var path = string.Concat("./Controllers/", args[0], ".cs");
                Console.WriteLine(path);

                File.Copy(
                    "./Files/DefaultValuesController.cs", 
                    path);
            } catch (Exception ex) {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
