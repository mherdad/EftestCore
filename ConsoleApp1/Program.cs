using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDb db=new ApplicationDb())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
            Console.WriteLine("Hello World!");
        }
    }
}