using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInit();
            
            StudentService studentService1=new StudentService();
            studentService1.Create("ali","ali@");
          
            Student stu1= studentService1.Read(1);
            Student stu2= studentService1.Read(1);
            if (stu1==stu2)
            {
               Console.WriteLine("ok");
            }

          
            if (stu1.Id==stu2.Id)
                Console.WriteLine("Id ok");
           
//            Update(1, "ali2", "ali2@");
//            Delete(1);
            Console.WriteLine("Hello World!");
        }

     

      

  

        private static void DbInit()
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}