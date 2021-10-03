using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext demoContext = new DemoContext();
            //demoContext.Database.EnsureDeleted();
            //demoContext.Database.EnsureCreated();

            Student student = new Student()
            {
                Address = "Tehran",
                Name = "amir",
                Surname="amiri"
            };
            demoContext.Students.Add(student);
            demoContext.SaveChanges();
         


            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
