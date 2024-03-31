using System.ComponentModel.Design;

namespace GroupMethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qrupun no daxil edin: ");
            string no = Console.ReadLine();
            int studentLimit;
            do
            {
                Console.Write("Qrupun telebe limitini qeyd edin: ");

            } while (!int.TryParse(Console.ReadLine(), out studentLimit));
            Group group = new Group(no,studentLimit);
           
            string answer;
            do
            {
                Console.WriteLine("\n1.Telebe elave et\n" +
                    "2. Bütün telebelere bax\n" +
                    "3. Telebeler üzre axtarış et\n" +
                    "0. Proqramı bitir");
                Console.WriteLine("Bir secim edin:");
                 answer = Console.ReadLine();

                if(answer == "1")
                {
                    Console.Write("Telebenin adini ve soyadini daxil edin: ");
                    string fullName = Console.ReadLine();
                    int groupNo;
                    do
                    {
                        Console.Write("Telebenin qrup no daxil edin: ");


                    } while (!int.TryParse(Console.ReadLine(), out groupNo));
                    double avgPoint;
                    do
                    {
                        Console.Write("Telebenin ortalamasini daxil edin: ");


                    } while (!double.TryParse(Console.ReadLine(), out avgPoint));
                   
                    Student student = new Student(fullName,groupNo,avgPoint);

                    group.AddStudent(student);
                    
                    



                }
                else if(answer == "2")
                {
                    group.ShowAllStudents();
                }
                else if(answer == "3")
                {
                    Console.Write("Axtarmaq istediyinin telebenin adini ve soyadini daxil edin: ");
                    string name = Console.ReadLine();
                    group.SearchStudents(name);
                }

            } while (answer != "0");
        }
    }
}
