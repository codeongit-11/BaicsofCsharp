/*
 * C# Program to Generate the Marksheet of the Student
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BasicsOfCsharp
{
    class StudentDetails
    {
        static void Main(string[] args)
        {
            int id;
            string name,dept;
            Console.WriteLine("Enter ID :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student's Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student's Department :");
            dept = Console.ReadLine();

            int nitem = 6;
            switch (nitem)
            {

                case 1:
                    Console.WriteLine(" Add Data");
                    break;

                case 2:
                    Console.WriteLine("Update Data");
                    break;

                case 3:
                    Console.WriteLine("Delete");
                    break;

                case 4:
                    Console.WriteLine("Display");
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;
            }

            
        }
    }
}