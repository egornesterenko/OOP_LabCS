using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab
{
    class Student : Person, ICloneable 
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation,
            PhD
        }

        public Education type { get; set; }
        public string group { get; set; }
        public string numRecord;

        public string NumRec
        {
            get
            {
                return numRecord;
            }
            set
            {
                if (Int32.Parse(value) <= 99999 || Int32.Parse(value)>= 99999999)
                {
                    throw new Exception("Некоректний проміжок значень, коректний - (99999 - 99999999)");
                }
                else
                {
                    numRecord = value;
                }
            }
        }

        public List<Examination> passedList { get; set; }
        public double middle { get; private set; }
        public static int count;

        public Student(string newName, string newSurname, string newBirthday, Education newType , string newGroup, string newNumRecord) : base(newName, newSurname, newBirthday)
        {
            name = newName;
            surname = newSurname;
            birthday = newBirthday;
            type = newType;
            group = newGroup;
            numRecord = newNumRecord;
            passedList = new List<Examination>();
            count++;
        }

        public Student()
        {
            name = "Jan";
            surname = "Kravetc";
            birthday = "11.06.2000";
            type = Education.Bachelor;
            group = "ip-72";
            numRecord = "99999";
            passedList = new List<Examination>();
            count++;
        }

        public void findMiddle()
        {
            if (passedList.Count > 0)
            {
                double c = 0;
                foreach (var exam in passedList)
                {
                    c += exam.mark;
                }
                middle = c / passedList.Count();
            }
            else
                middle = 0;
        }

        public IEnumerable GetExaminations(int mark)
        {
            foreach (var exam in passedList)
                if (exam.mark >= mark)
                    yield return exam;
        }

        public void AddExams(Examination[] examList)
        {
            for (int i = 0; i < examList.Length; i++)
            {
                if (examList[i].mark>60)
                {
                    passedList.Add(examList[i]);
                }
            }
        }
        public override string ToString()
        {
            string st = name + " " + surname + " " + group;
            return st;
        }


        public string printList(List<Examination> passrdList)
        {
            string res = "";
            foreach (Examination p in passrdList)
            {
                res += p.subject + " ";
            }
            return res;
        }

        public new void PrintFullInfo()
        {
            findMiddle();
            string res = name + " " + this.surname + " " + Birthday + " " + type + " " +
                    group + " " + numRecord + " " + printList(passedList) + " " + middle + "\n";
            Console.Write(res);
        }

        public object Clone()
        {
            List<Examination> newList = new List<Examination>();

            for (int i = 0; i < passedList.Count; i++)
            {
                newList.Add(passedList[i]);
            }
            return new Student
            {
                name = this.name,
                surname = this.surname,
                birthday = this.birthday,
                type = this.type,
                group = this.group,
                numRecord = this.numRecord,
                passedList = newList,
                middle = this.middle
               
            };
        }
    }

}
