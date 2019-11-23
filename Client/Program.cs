using Client.WebServiceReference;
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
            WebServiceReference.Service1Client client = new Service1Client();


            User login = null; ;
            string username, password, readKey;
            int serviceNumber;
            char readNumber;

            string idStudent = "", usernam = "", passwor = "", name = "", surname = ""; // for adding new users

            //login = new User();
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
                serviceNumber++ + " Povprečna dolžina imena osebe\n" +
                serviceNumber++ + " Dodajanje novega študenta\n" +
                "a Dodajanje novega uporabnika\n" +
                "b Dodajanje novega predmeta\n" +
                "c Dodajanje nove povezave študent-predmet\n" +
                "d Urejanje imena študenta\n" +
                "e Urejanje imena uporabnika\n" +
                "f Urejanje naziva predmeta\n" +
                "g Brisanje študenta\n" +
                "h Brisanje Uporabnika\n" +
                "i Brisanje predmeta\n" +
                "j Brisanje povezave študent-predmet\n" +
                "k Dodajanje izvajalca h predmetu\n"
                );

                if (login.type == userType.referent)
                    Console.WriteLine(serviceNumber++ + " Izpis vseh študentov\n" + serviceNumber++ + " Izpis vseh predmetov");

                Console.Write("\nVnesite številko funkcije: ");

                readNumber = Console.ReadKey().KeyChar;


                string readLine = "";
                Student student;
                List<Student> seznamStudentov;
                List<Subject> seznamPredmetov;
                try
                {


                    switch (readNumber)
                    {
                        case '0':
                            login = null;
                            client.Close();
                            return;
                        case '1':
                            Console.Write("\nVnesi vpisno številko: ");
                            readLine = Console.ReadLine();
                            student = client.GetStudent((string)readLine);
                            Console.WriteLine("\nŠtudent z idjem " + readLine + " je " + student.user.name + " " + student.user.surname);
                            break;
                        case '2':
                            student = client.GetBiggestSubject();
                            Console.WriteLine("\nŠtudent z največimi predmeti je " + student.idStudent);
                            break;
                        case '3':
                            Console.Write("\nVnesite id predmeta: ");
                            readLine = Console.ReadLine().ToString();
                            seznamStudentov = client.GetStudentsFromSubject(Int32.Parse(readLine)).ToList<Student>();
                            foreach (Student st in seznamStudentov)
                            {
                                Console.WriteLine(st.idStudent);
                            }
                            break;
                        case '4':
                            Console.Write("\nVnesite id študenta (ne vpisna): ");
                            readLine = Console.ReadLine().ToString();
                            seznamPredmetov = client.GetSubjectsFromStudent(Int32.Parse(readLine)).ToList<Subject>();
                            foreach (Subject su in seznamPredmetov)
                            {
                                Console.WriteLine(su.name);
                            }
                            break;
                        case '5':
                            User user = client.GetLongestName();
                            Console.WriteLine("\nUporabnik z najdaljšim imenom je " + user.name);
                            break;
                        case '6':
                            Console.WriteLine("\nPovprečna dolžina imena vseh oseb na FERI je " + client.GetAverageNameLength() + " črk.");
                            break;
                        case '7':
                            seznamStudentov = client.GetStudents().ToList<Student>();
                            foreach (Student st in seznamStudentov)
                            {
                                Console.WriteLine(st.idStudent);
                            }
                            break;
                        case '8':
                            seznamPredmetov = client.GetSubjects().ToList<Subject>();
                            foreach (Subject su in seznamPredmetov)
                            {
                                Console.WriteLine(su.name);
                            }
                            break;
                        case '9':
                            // add student
                            Console.WriteLine("Vnesi id studenta: ");
                            idStudent = Console.ReadLine();

                            Console.WriteLine("Vnesi uporabnisko ime: ");
                            usernam = Console.ReadLine();

                            Console.WriteLine("Vnesi geslo: ");
                            passwor = Console.ReadLine();

                            Console.WriteLine("Vnesi ime studenta: ");
                            name = Console.ReadLine();

                            Console.WriteLine("Vnesi priimek studenta: ");
                            surname = Console.ReadLine();

                            client.AddStudent(idStudent, usernam, passwor, name, surname);
                            break;
                        case 'a':
                            // add user
                            User newUser;

                            Console.WriteLine("Vnesi uporabnisko ime: ");
                            usernam = Console.ReadLine();

                            Console.WriteLine("Vnesi geslo: ");
                            passwor = Console.ReadLine();

                            Console.WriteLine("Vnesi ime osebe: ");
                            name = Console.ReadLine();

                            Console.WriteLine("Vnesi priimek osebe: ");
                            surname = Console.ReadLine();

                            Console.WriteLine("Vnesi tip računa (referent/student): ");
                            string type = Console.ReadLine();


                            client.AddUser(usernam, passwor, name, surname, type);
                            
                            break;
                        case 'b':
                            Console.WriteLine("Vnesi ime predmeta");
                            string ime = Console.ReadLine();

                            client.AddSubject(ime);

                            break;
                        case 'c':

                            Console.WriteLine("Vnesi id študenta: ");
                            idStudent = Console.ReadLine();

                            Console.WriteLine("Vnesi id predmeta: ");
                            dynamic idSubject = Console.ReadLine();

                            idSubject = Int32.Parse(idSubject);

                            client.AddStudentSubject(idStudent, idSubject);
                            break;
                        case 'd':
                            //edit something
                            Console.WriteLine("Vnesi id studenta katerega hoces urediti:");
                            idStudent = Console.ReadLine();

                            Console.WriteLine("Vnesi novo ime studenta");
                            name = Console.ReadLine();


                            client.EditStudent(idStudent, name);

                            break;
                        case 'e':
                            Console.WriteLine("Vnesi id uporabnika katerega hocas urediti:");
                            idSubject = Console.ReadLine();
                            idSubject = Int32.Parse(idSubject);

                            Console.WriteLine("Vnesi novo ime uporabnika");
                            name = Console.ReadLine();


                            client.EditUser(idSubject, name);
                            break;
                        case 'f':
                            //uredi predmet
                            Console.WriteLine("\nTODO");

                            break;
                        case 'g':
                            Console.WriteLine("Vnesi id za brisanje: ");
                            idStudent = Console.ReadLine();

                            client.DeleteStudent(idStudent);
                            break;
                        case 'h':
                            Console.WriteLine("Vnesi id za brisanje: ");
                            idSubject = Console.ReadLine();
                            idSubject = Int32.Parse(idSubject);

                            client.DeleteUser((int)idSubject);
                            break;
                        case 'i':
                            Console.WriteLine("Vnesi id za brisanje: ");
                            idSubject = Console.ReadLine();
                            idSubject = Int32.Parse(idSubject);

                            client.DeleteSubject(idSubject);
                            break;
                        case 'j':
                            Console.WriteLine("Vnesi id za brisanje: ");
                            idSubject = Console.ReadLine();
                            idSubject = Int32.Parse(idSubject);

                            client.DeleteStudentSubject(idSubject);
                            break;
                        case 'k':
                            Console.WriteLine("Vnesi id uporabnika katerega želiš dodati");
                            dynamic idUser = Console.ReadLine();
                            idUser = Int32.Parse(idUser);

                            Console.WriteLine("Vnesi id predmeta h katerem želiš dodati uporabnika");
                            idSubject = Console.ReadLine();
                            idSubject = Int32.Parse(idSubject);

                            client.AddUserToSubject(idUser, idSubject);

                            break;

                        default:
                            break;
                    }
                }
                finally
                {

                }
            }
        }
    }
}
