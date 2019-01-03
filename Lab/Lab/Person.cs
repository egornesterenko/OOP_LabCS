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
        protected string birthday;

        public string Birthday
        {
            get
            {
                string[] split = birthday.Split(new Char[] { '.' });
                return split[2];
            }
            set
            {
                if (Int32.Parse(value) > DateTime.Now.Year)
                {
                    return;
                }
                else 
                {
                    string[] split = birthday.Split(new Char[] { '.' });
                    split[2] = value;
                    birthday = split[0] + '.' + split[1] + '.' + split[2];
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