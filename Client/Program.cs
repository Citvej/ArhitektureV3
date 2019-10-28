using Client.WebServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceClient.Service1Client client = new WebServiceClient.Service1Client();


            User login = null; ;
            string username, password, readKey;
            int serviceNumber, readNumber;


            while (login == null)
            {
                Console.WriteLine("Vnesi uporabniško ime: ");
                username = Console.ReadLine();
                Console.WriteLine("Vnesi geslo: ");
                password = Console.ReadLine();

                login = client.Login(username, password);

                if (login != null)
                    Console.WriteLine("Vpis uspešen!");
                else
                    Console.WriteLine("Napačno uporabniško ime ali geslo. Poskusite znova.");
            }

            while (true)
            {
                serviceNumber = 0;

                Console.WriteLine(
                "\nPozdravljeni v programu. \n" +
                "\nSeznam funkcij: \n" +
                serviceNumber++ + " Izhod \n" +
                serviceNumber++ + " Izpis študenta na podlagi vpisne št. \n" +
                serviceNumber++ + " Študent z največ predmeti\n" +
                serviceNumber++ + " Seznam študentov enega predmeta \n" +
                serviceNumber++ + " Seznam predmetov enega študenta \n" +
                serviceNumber++ + " Oseba z najdaljšim imenom \n" +
                serviceNumber++ + " Povprečna dolžina imena osebe\n"
                );

                if (login.type == userType.referent)
                    Console.WriteLine(serviceNumber++ + " Izpis vseh študentov\n" + serviceNumber++ + " Izpis vseh predmetov");

                Console.Write("\nVnesite številko funkcije: ");

                readKey = Console.ReadKey().KeyChar.ToString();

                if( ! Int32.TryParse(readKey, out readNumber) )
                {
                    Console.WriteLine("\nNiste vnesli števila!\n\n");
                    continue;
                }

                string readLine = "";
                Student student;
                Subject subject;
                List<Student> seznamStudentov;
                List<Subject> seznamPredmetov;
                switch (readNumber)
                {
                    case 0:
                        login = null;
                        return;
                        break;
                    case 1:
                        Console.Write("\nVnesi vpisno številko: ");
                        readLine = Console.ReadLine();
                        student = client.GetStudent(readLine);
                        Console.WriteLine("\nŠtudent z idjem " + readLine + " je " + student.user.name + " " + student.user.surname);
                        break;
                    case 2:
                        student = client.GetBiggestSubject();
                        Console.WriteLine("\nŠtudent z največimi predmeti je " + student.idStudent);
                        break;
                    case 3:
                        Console.Write("\nVnesite id predmeta: ");
                        readLine = Console.ReadLine().ToString();
                        seznamStudentov = client.GetStudentsFromSubject(Int32.Parse(readLine)).ToList<Student>();
                        foreach(Student st in seznamStudentov)
                        {
                            Console.WriteLine(st.idStudent);
                        }
                        break;
                    case 4:
                        Console.Write("\nVnesite id študenta (ne vpisna): ");
                        readLine = Console.ReadLine().ToString();
                        seznamPredmetov = client.GetSubjectsFromStudent(Int32.Parse(readLine)).ToList<Subject>();
                        foreach (Subject su in seznamPredmetov)
                        {
                            Console.WriteLine(su.name);
                        }
                        break;
                    case 5:
                        User user = client.GetLongestName();
                        Console.WriteLine("\nUporabnik z najdaljšim imenom je " + user.name);
                        break;
                    case 6:
                        Console.WriteLine("\nPovprečna dolžina imena vseh oseb na FERI je " + client.GetAverageNameLength() + " črk.");
                        break;
                    case 7:
                        seznamStudentov = client.GetStudents().ToList<Student>();
                        foreach (Student st in seznamStudentov)
                        {
                            Console.WriteLine(st.idStudent);
                        }
                        break;
                    case 8:
                        seznamPredmetov = client.GetSubjects().ToList<Subject>();
                        foreach (Subject su in seznamPredmetov)
                        {
                            Console.WriteLine(su.name);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
