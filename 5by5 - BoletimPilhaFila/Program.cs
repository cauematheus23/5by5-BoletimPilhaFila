using _5by5___BoletimPilhaFila;

int opc;
StudentStack stack = new();
GradeQueue queue = new(stack);
int Number_Student()
{
    Console.WriteLine("Write student ID: ");
    return int.Parse(Console.ReadLine());
}
void Menu()
{
    Console.WriteLine("[1] - Register a student");
    Console.WriteLine("[2] - Register a note");
    Console.WriteLine("[3] - Calculate the student average");
    Console.WriteLine("[4] - List the names of students without grades");
    Console.WriteLine("[5] - Delete student");
    Console.WriteLine("[6] - Delete note");
    Console.WriteLine("[7] - Print StudentStack");
    Console.WriteLine("[8] - Print GradeQueue");
    Console.WriteLine("[9] - Exit");
}
do
{
    Console.Clear();
    Menu();
    Console.WriteLine("Write a number: ");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.WriteLine("Write a name: ");
            stack.Push(new(Console.ReadLine()));
            break;
        case 2:
            int number_student, grade;
            number_student = Number_Student();
            Console.WriteLine("Write grade: ");
            grade = int.Parse(Console.ReadLine());
            queue.RegisterNote(number_student, new(number_student, grade));
            break;
        case 3:
            queue.StudentAverage(Number_Student());
            break;
        case 4:
            queue.StudentWithoutGrade();
            break;
        case 5:
            stack.Pop(queue);
            break;
        case 6:
            queue.DeleteGradesByStudent(Number_Student());
            break;
        case 7:stack.Print();
            break;
        case 8:queue.Print();
            break;
        case 9:
            Environment.Exit(0);
            break;
        default:
            break;
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
} while (true);

