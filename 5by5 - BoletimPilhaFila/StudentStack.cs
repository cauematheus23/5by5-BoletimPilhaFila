using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5___BoletimPilhaFila
{
    internal class StudentStack
    {
        int number_students;
        Student top;

        public StudentStack()
        {
            this.top = null;
            this.number_students = 0;
        }
        bool IsEmpty()
        {
            return this.top == null;
        }
        public void Push(Student aux)
        {
            number_students++;
            aux.setNumber(number_students);
            
            if(IsEmpty())
            {
               
                this.top = aux;
            }
            else
            {
                aux.setPrevious(top);
                top = aux;
            }
        }
        public void Pop(GradeQueue gradequeue)
        {
            int y;
            if(IsEmpty())
            {
                Console.WriteLine("Stack empty");
            }

            if(gradequeue.StudentHasGrades(top.getNumber()) > 0)
            {
                Console.WriteLine("The student have grades");
                Console.WriteLine("Do you still want to remove it? \n[1] - YES\n[2] - NO");
                y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    ForcePop(gradequeue);
                }
                else
                {
                    return;
                }
            }
            else
            {
                top = top.getPrevious();
                number_students--;
                Console.WriteLine("Student successfully deleted!");
            }
        }
        public void ForcePop(GradeQueue gradequeue)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack empty");
            }

            if (gradequeue.StudentHasGrades(top.getNumber()) > 0)
            {
                gradequeue.DeleteGradesByStudent(top.getNumber());
                top = top.getPrevious();
                number_students--;
            }


        }
        public void Print()
        {
            Student aux = this.top;
            if (IsEmpty())
            {
                Console.WriteLine("Stack empty");
            }
            else
            {
                for (aux = top; aux != null; aux = aux.getPrevious())
                {
                    Console.WriteLine(aux.ToString());
                }
                
            }
        }
        public Student getTop()
        {
            return this.top;
        }
        
    }
}
