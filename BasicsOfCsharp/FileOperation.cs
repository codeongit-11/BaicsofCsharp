using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCsharp
{
    class FileOperation
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://employee.txt", content);
        }

        public void UpdateFile()
        {
            string employee = Environment.NewLine + "JonDoe, 1, Finance";
            File.AppendAllText("C://employee.txt", employee);
        }

        public void ReadFile()
        {
            string content = File.ReadAllText("C://employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://employee.txt");
            foreach (string str in contents)
            {
                Console.WriteLine(str);

            }
        }

        public void DeleteFile()
        {
            if (File.Exists("C://employee.txt"))
            {
                File.Delete("C://employee.txt");
            }
        }
    }
}

