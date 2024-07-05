using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCampus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();
            List<Campus> camp = new List<Campus>();

            while(true)
            {
                Menu(stud, camp);
            }
        }

        public static void Menu(List<Student> stud,List<Campus> camp)
        {
            int option;
            Console.WriteLine("Select Info");
            Console.WriteLine("*******************");
            Console.WriteLine("1. Enter Campuses available\n2. Enter Student Data\n3. Display Campus info\n4. Display Student info\n5. Display Student along with his campus data\n6. Update Student\n7. Delete Student\n8. Exit Program");
            option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:

                    CampusData(camp);
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    StudentData(stud);
                    break;

                case 3:
                    Console.Clear();
                    DisplayCampus(camp);

                    break;

                case 4:
                    Console.Clear();
                    DisplayStudent(stud);

                    break;


                case 5:
                    Console.Clear();
                    CombinedOutput(stud, camp);

                    break;

                case 6:


                    break;

                case 7:


                    break;

                case 8:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Incorrect Selection");
                    break;

            }
        }
        public static void CampusData(List<Campus> camp)
        {
            Console.WriteLine("How many Campuses will you input Data for? ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int k = 0;k < num;k++)
            {
                Console.WriteLine("What is the name of the campus?");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Province");
                string province = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter City");
                string city = Convert.ToString(Console.ReadLine());

                Console.WriteLine("What is the Surbub");
                string surbub = Convert.ToString(Console.ReadLine());

                camp.Add(new Campus(name, province, city, surbub));

            }
            Console.Clear();
           
            foreach(var campus in camp)
            {
                Console.WriteLine(campus);
                Console.WriteLine("\n");
            }

        }

        public static void StudentData(List<Student> stud)
        {
            Console.WriteLine("How many students will input?");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int l = 0;l < num;l++)
            {
                Console.WriteLine("Enter Student Name");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Student Surname");
                string surname = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Student Campus");
                string campus = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Student Degree");
                string degree = Convert.ToString(Console.ReadLine());

                stud.Add(new Student(name, surname, campus, degree));
            }
            Console.Clear();
            foreach(var student in stud)
            {
                Console.WriteLine(student);
                Console.WriteLine("\n");
            }
        }

        public static void DisplayCampus(List<Campus> camp)
        {
            Console.WriteLine("Look for Campus");
            string cname = Console.ReadLine();

            bool campusFound = false;

            for(int i=0;i < camp.Count; i++)
            {
                
                if(camp[i].Name.Equals(cname, StringComparison.OrdinalIgnoreCase))
                {
                    campusFound = true;

                    Console.WriteLine("Campus Found");
                    Console.WriteLine($"Name: {camp[i].Name} \nProvince: {camp[i].Province} \nCity: {camp[i].City} \nSurbub: {camp[i].Surbub}");
                }
            }

            if (!campusFound)
            {
                Console.WriteLine("Campus does not exist");
            }
        }

        public static void DisplayStudent(List<Student> stud)
        {
            Console.WriteLine("Enter student name to search");
            string name = Console.ReadLine();

            bool studentFound = false;

            for(int i=0;i < stud.Count; i++)
            {
                if (stud[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase)){
                    studentFound = true;

                    Console.WriteLine("Student found");
                    Console.WriteLine($"{stud[i].Name}\n Surname: {stud[i].Surname} \nDegree: {stud[i].Degree}");
                    break;
                }
            }

            if (!studentFound)
            {
                Console.WriteLine("Student does not exist");
            }
        }

        public static void CombinedOutput(List<Student> stud,List<Campus> camp)
        {
            Console.WriteLine("Enter Student name");
            string name = Convert.ToString(Console.ReadLine());

            bool found = false;

            foreach(var student in stud)
            {
                if(name == student.Name)
                {

                    foreach (var campus in camp)
                    {
                        if (student.Campus == campus.Name)
                        {
                            Console.WriteLine(student);
                            Console.WriteLine(camp);

                            found = true;
                            break;
                        }
                    }                    
                }
             
            }

            if(!found)
            {
                Console.WriteLine("Student wih name -{0}- was not found", name);
            }
        }
    }
}
