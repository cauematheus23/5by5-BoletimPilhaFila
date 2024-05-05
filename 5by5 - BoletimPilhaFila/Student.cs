using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5___BoletimPilhaFila
{
    internal class Student
    {
        int number;
        string name;
        Student previous;
       

        public Student(string name)
        {
            this.name = name;
            this.previous = null;
            
        }
        public void setNumber(int number)
        {
            this.number = number;
        }
        public int getNumber()
        {
            return number;
        }
        public void setPrevious(Student previous)
        {
            this.previous = previous;
        }
        public Student getPrevious()
        {
            return this.previous;
        }
        public override string? ToString()
        {
            return "Name: " + this.name + "\nNumber: " + this.number;
        }
    }
}
