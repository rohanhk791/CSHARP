using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
  
    public class em
    {
        int Tid;
        string Tname;

        
        public void getinfo()
        {
            Console.WriteLine("Enter Trainee ID");
            Tid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name");
            Tname = Console.ReadLine();
            
        }

        
        public void display()
        {
            Console.WriteLine("Trainee ID    : {0}", Tid);
            Console.WriteLine($"Trainee Name : {Tname}");
            
        }

        public static void Main()
        {
            int n;
            trainee t = new trainee();
            //Asking for how many number of records to be entered
            Console.WriteLine("Enter the number of Trainees");
            n = Convert.ToInt32(Console.ReadLine());

            //for loop 
            for (int i = 0; i < n; i++)
            {
        
                t.getinfo();
                Console.WriteLine("");
                
                t.display();
                Console.WriteLine("");
                Console.WriteLine("Trainee Details Added Successfully");


            }
        }
    }
}

