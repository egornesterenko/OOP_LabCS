using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nesterenko Yehor  IP-72  17var");

            Student firstStudent = new Student("Kriss", "Dalaman", "10.12.1998", Student.Education.Bachelor, "ip-74", "844969");
            Console.Write("\nfistStudent ToString: ");
            Console.WriteLine(firstStudent.ToString());

            Examination one = new Examination(1, "Math", "Mickel O.", 91, "Def", "10.11.2018");
            Examination two = new Examination(2, "Phisik", "Linchevski K.", 80, "Non-Def", "10.01.2018");
            Examination[] array = { one, two };
            firstStudent.AddExams(array);
            Console.Write("\nfirstStudent PrintFull: ");
            firstStudent.PrintFullInfo();

            Student secondStudent = new Student();
            Console.Write("\nsecondStudent PrintFull: ");
            secondStudent.PrintFullInfo();
            Student thirdStudent = new Student("Nikki", "Jackson", "10.08.1990", Student.Education.PhD, "ip-34", "944969");

            Console.Write("\nКіьлькість об'єктів Student:");
            Console.Write(Student.count);

            Console.WriteLine("\n\nЕкзамени з середнім балом вищим за 90: ");
            foreach (Examination exm in firstStudent.GetExaminations(91))
            {
                Console.WriteLine(exm);
            }

            Console.Write("\nКлонування firstStudent:");
            Student cloneStud = (Lab.Student)firstStudent.Clone();
            cloneStud.PrintFullInfo();

            Console.Write("\n\nСпроба ввести некоректний номер заліковки:\n");
            try
            {
                secondStudent.NumRec = "9999";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

        }
        }
    }