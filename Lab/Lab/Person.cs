using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        protected DateTime birthday;

        public string Birthday
        {
            get
            {
                return birthday.Year;
            }
            set
            {
                if (Int32.Parse(value) > DateTime.Now.Year)
                {
                    return;
                }
                else 
                {
                    int day = birthday.Day;
                    int month = birthday.Month;
                    birthday = new DateTime(value, month, day);
                }

            }
        }
        public Person()
        {
            name = "Ivan";
            surname = "Pupkin";
            birthday = "01.01.1990";
        }
        public Person(string newName, string newSurname, string newBirthday)
        {
            name = newName;
            surname = newSurname;
            birthday = newBirthday;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: " + name + " Surname:" + surname + " Birthday:" + birthday);
        }
    }
}
