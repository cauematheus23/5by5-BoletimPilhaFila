using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5___BoletimPilhaFila
{
    internal class GradeQueue
    {
        StudentStack stack;
        Grade head;
        Grade tail;

        public GradeQueue(StudentStack stack)
        {
            this.stack = stack;
            this.head = null;
            this.tail = null;
        }
        bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public bool StudentGradeQueue(int id)
        {
            StudentStack s = this.stack;
            for (Student aux = s.getTop(); aux != null; aux = aux.getPrevious())
            {
                if (id == aux.getNumber())
                {
                    return true;
                    
                }
            } return false;
        }
        public int StudentHasGrades(int id)
        {
            int cont_grades = 0;
            if (StudentGradeQueue(id) == true)
            { for(Grade walk = head; walk != null; walk = walk.GetNext())
                {
                    if (walk.GetStudentNumber() == id)
                    { 
                         cont_grades++;
                        
                    }
                }
            } return cont_grades;
        }
        public void StudentAverage(int id)
        {
            int indice = 0;
            int[] grades = new int[2];
            if (StudentGradeQueue(id) == true)
            {
                if(StudentHasGrades(id) == 2)
                {
                    for(Grade walk = head;walk != null; walk = walk.GetNext())
                    {
                        if (walk.GetStudentNumber() == id)
                        {
                            grades[indice] = walk.GetGrade();
                            indice++;

                        }


                    }
                    int average = (grades[0] + grades[1]) / 2;
                    Console.WriteLine($"Student id : {id}\nAverage: {average}");
                }
                else
                {
                    Console.WriteLine("the student does not have a grade");
                }
            }
            else
            {
                Console.WriteLine("the student doesn't in queue");
            }



        }
        public  void RegisterNote(int studentNumber, Grade grade)
        {
                if (StudentGradeQueue(studentNumber) == true)
                {
                    if (IsEmpty()) { 
                    head = tail = grade;
                    }
                    else
                    {
                        tail.SetNext(grade);
                        tail = grade;
                    }
                    Console.WriteLine("Grade registered!");
                    return;
                }
        }
        public void DeleteGradesByStudent(int studentNumber)
        {
            Grade prev = null;
            Grade current = head;
            while (current != null)
            {
                if (current.GetStudentNumber() == studentNumber)
                {
                    if (prev == null)
                    {
                        head = current.GetNext();
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    else
                    {
                        prev.SetNext(current.GetNext());
                        if (current == tail)
                        {
                            tail = prev;
                        }
                    }
                    
                    current = current.GetNext();
                }
                else
                {
                    prev = current;
                    current = current.GetNext();
                }
            }
        }
        public void StudentWithoutGrade()
        {
           
            Console.WriteLine("Students without grades");
            StudentStack s = this.stack;
            for (Student aux = s.getTop(); aux != null; aux = aux.getPrevious())
            {   bool hasGrade = false;
                for (Grade walk = head; walk != null; walk = walk.GetNext())
                {
                    if (walk.GetStudentNumber() == aux.getNumber())
                    {
                        hasGrade = true;
                        break;

                    }
                }
                if (!hasGrade)
                {
                    Console.WriteLine(aux.ToString());
                }
            }
        }
            public void Print()
        {
            Grade aux = head;
            if (IsEmpty())
            {
                Console.WriteLine("Empty queue, nothing for print");
            }
            else
            {
                do
                {
                    
                    Console.Write(" " + aux.ToString());
                    aux = aux.GetNext();

                } while (aux != null);


            }
            Console.WriteLine();
        }
    }
}
