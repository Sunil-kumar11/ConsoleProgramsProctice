using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramsProctice
{
 public   class Student
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    class ListExample
    {

        List<Student> Students = new List<Student> {
            new Student
            {
                Id=121,
                UserName = "raju",
                Password = "Raju@123"
            },
            new Student
            {
                Id=122,
                UserName = "suresh",
                Password = "suresh@123"
            },
            new Student
            {
                Id=123,
                UserName = "vikas",
                Password = "vikas@123"
            },
            new Student
            {
                Id=124,
                UserName = "raju",
                Password = "mahesh@123"
            }
          };
        static void Main(string[] args)
        {

            ListExample obj = new ListExample();

            
            obj.Check1();
        }
        public void Check1()
        {
            Console.WriteLine("enter username :");
            string UName = Console.ReadLine();
            Console.WriteLine("enter password :");
            string Pswd = Console.ReadLine();



            var obj = Students.Where(a => a.UserName.Equals(UName) && a.Password.Equals(Pswd)).SingleOrDefault();
            if (obj != null)
            {

                Console.WriteLine("Login succeessfull");
            }
            else
            {
                Console.WriteLine("UserName Or Password is Wrong please enter correct UserName And Password");
                
            }


            //var name = Students.Where(x => x.UserName.Equals(UName));
            //var pswd = name.Where(x => x.Password.Equals(Pswd));
            //Console.WriteLine(name);
            //Console.WriteLine(pswd);

            
        } 
    }
}
