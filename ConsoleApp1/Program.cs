using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInit();
            Create("ali","ali@");
            Student stu1= Read(1);
            Student stu2= Read(1);
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

        private static void Delete(int id)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu= db.Students.Find(id);
                db.Students.Remove(stu);
                db.SaveChanges();
            }
        }

        private static void Update(int id, string newName, string newEmail)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu=db.Students.Find(id);
                stu.Name = newName;
                stu.Email = newEmail;
                db.SaveChanges();
            }
        }

        private static Student Read(int Id)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu= db.Students.Find(Id);
                return stu;
                Console.WriteLine(stu);
            }
        }

        private static void DbInit()
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }

        public static void Create(string name, string email)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student student = new Student() {Name = name, Email = email};
                db.Students.Add(student);
                db.SaveChanges();

            }

        }
    }
}