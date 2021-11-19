using System;

namespace ConsoleProgramsProctice
{
    public class Program
    {
        static void Main(string[] args)
        {


            string[] EmployeeNames = { "ravi", "raju", "Praveen", "vikas" };
            string[] UserName = { "RaviKumar", "RajuKuamr", "PraveenKumar", "vikas123" };
            string[] Password = { "Ravi123", "Raj345", "praveen989", "vikas678" };
            int[] Id = { 1, 2, 3, 4, };


            string EmployeeDetails = "EmployeeDetails  :";

            string UserNames = "";
            for (int i = 0; i <= UserName.Length - 1; i++)
            {
                UserNames += UserName[i] + " ,";
            }


            string Employees = "";
            for (int i = 0; i <= EmployeeNames.Length - 1; i++)
            {
                Employees += EmployeeNames[i] + ",";
            }

            string Passwords = "";
            for (int i = 1; i < Password.Length - 1; i++)
            {
                Passwords += Password[i] + " ,";

            }
            string Ids = "";
            for (int i = 0; i <= Id.Length - 1; i++)
            {
                Ids += Id[i] + " ,";
            }

            EmployeeDetails = "EmployeesDetails  :" + Employees + " UserNames : " + UserNames + "Passwords :" + Passwords + "Employees Ids : " + Ids;
            Console.WriteLine(EmployeeDetails);

            Console.Write("Please enter the UserName :");
            string username =Console.ReadLine();
            Console.Write("Please enter the Password :");
            string password = Console.ReadLine();


            string checkedusername = "";
            string checkedpassword = "";
            for (int i = 0; i < UserName.Length - 1; i++)
            {
                if (username == UserName[i])
                {
                    checkedusername = username; 

                    for (int j = 0; j < Password.Length - 1; j++)
                    {

                        if (password == Password[j])
                        {
                            checkedpassword = password;
                        }
                        
                    }

                }
               
            }
            if(checkedusername == username && checkedpassword == password)
            {
                Console.WriteLine("Longin Success");
            }
            else
            {
                Console.WriteLine("username or password wrong please check");
            }

            Console.Read();
        }
    }
    
}
