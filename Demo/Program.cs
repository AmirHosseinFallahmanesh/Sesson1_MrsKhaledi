using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext demoContext = new DemoContext();
            //demoContext.Database.EnsureDeleted();
            //demoContext.Database.EnsureCreated();

            //InsertDemo(demoContext);


            var data = demoContext.Students.ToList();

            Test();

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        private static void Test()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void InsertDemo(DemoContext demoContext)
        {
            Student student = new Student()
            {
                Address = "Tehran",
                Name = "amir",
                Surname = "amiri"
            };
            demoContext.Students.Add(student);
        }
    }
}
