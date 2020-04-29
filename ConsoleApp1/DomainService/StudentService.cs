using System;

namespace ConsoleApp1
{
  

  

   
    public  class StudentService
    {
        public  Student Read(int Id)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu= db.Students.Find(Id);
                return stu;
                Console.WriteLine(stu);
            }
        }
        
        private  void Delete(int id)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu= db.Students.Find(id);
                db.Students.Remove(stu);
                db.SaveChanges();
            }
        }
        
        private  void Update(int id, string newName, string newEmail)
        {
            using (ApplicationDb db = new ApplicationDb())
            {
                Student stu=db.Students.Find(id);
                stu.Name = newName;
                stu.Email = newEmail;
                db.SaveChanges();
            }
        }
        
        public  void Create(string name, string email)
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