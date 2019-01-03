using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{

    public class Examination
    {
        private int semNum;

        public int Semester
        {
            get { return semNum; }
            set
            {
                if (value > 0 && value < 4)
                    semNum = value;
            }
        }

        public string subject { get; set; }
        public string teacher { get; set; }
        public int mark { get; set; }
        public string type { get; set; }
        public string date { get; set; }

        public Examination()
        {
            semNum = 1;
            subject = "Math";
            teacher = "Ivanov I.I.";
            mark = 100;
            type = "dif";
            date = "10.01.2019";
        }
        public Examination(int newSemNum, string newSubject, string newTeacher,
                           int newMark, string newType, string newDate)
        {
            semNum = newSemNum;
            subject = newSubject;
            teacher = newTeacher;
            mark = newMark;
            type = newType;
            date = newDate;
        }

        public override string ToString()
        {
            string st = subject + " " + teacher + " " + mark;
            return st;
        }
    }
}