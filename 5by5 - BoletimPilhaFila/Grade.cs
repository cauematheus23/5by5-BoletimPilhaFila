using System;

namespace _5by5___BoletimPilhaFila
{
    internal class Grade
    {
        private int studentNumber;
        private int grade;
        private Grade next;

        public Grade(int studentNumber, int grade)
        {
            this.studentNumber = studentNumber;
            this.grade = grade;
            this.next = null;
        }

        public override string? ToString()
        {
            return " Student Number: " + studentNumber + " Grade: " + grade;
        }

        public void SetNext(Grade nextNote)
        {
            this.next = nextNote;
        }

        public Grade GetNext()
        {
            return this.next;
        }

        public int GetStudentNumber()
        {
            return this.studentNumber;
        }

        public int GetGrade()
        {
            return this.grade;
        }
    }
}
