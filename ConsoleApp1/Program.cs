using EfConsoleAppCrudSample;

namespace EfConsoleAppCrudSample
{
    public class Program
    {
        static void Main(string[] args)
        {


            Insert();
            Update();
            Delete();
            Select();
        }

        public static void Select()
        {
    
            Student students = new Student();

            Course courses= new Course();


            MyDBContext db = new MyDBContext();
            List<Student> list = db.Students.ToList();
            List<Course> list2=db.Courses.ToList();
            foreach (Student item in list)
            {
                Console.WriteLine(item.Name);
               
            }
            Console.WriteLine("");
            foreach (Course item in list2)
            {
                
                Console.WriteLine(item.CourseName);
                
            }
            Console.WriteLine("");
            Console.WriteLine("Veriler Listelendi");
             

            Console.ReadKey();
        }

        public static void Insert()
        {
            Console.Write("Öğrenci adı giriniz : ");
            string stuName = Console.ReadLine();
            Console.Write("Kurs adı giriniz : ");
            string couName = Console.ReadLine();

            Student s1 = new Student();
            s1.Name = stuName;
            Course c1 = new Course();
            c1.CourseName = couName;

            MyDBContext db = new MyDBContext();
            db.Students.Add(s1);
            db.Courses.Add(c1);
            db.SaveChanges();

            Console.WriteLine("Eklendi");
            Console.ReadKey();
        }

        public static void Update()
        {
            Console.Write("Öğrenci Id Giriniz : ");
            int stuId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Öğrenci adı giriniz : ");
            string stuName = Console.ReadLine();
            Console.Write("Kurs Id Giriniz : ");
            int couId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kurs adı giriniz : ");
            string couName = Console.ReadLine();

            MyDBContext db = new MyDBContext();
            Student stu1 = db.Students.Find(stuId);
            stu1.Name = stuName;

            Course cou1 = db.Courses.Find(couId);
            cou1.CourseName = couName;

            db.SaveChanges();
            Console.WriteLine("Bilgiler Güncellenmiştir");
            Console.ReadKey();



        }

        public static void Delete()
        {
            Console.Write("Öğrenci Id Giriniz : ");
            int stuId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kurs Id Giriniz : ");
            int couId = Convert.ToInt32(Console.ReadLine());
            MyDBContext db = new MyDBContext();
            Student stu1 = db.Students.Find(stuId);
            Course cou1 = db.Courses.Find(couId);
            db.Students.Remove(stu1);
            db.Courses.Remove(cou1);
            db.SaveChanges();
            Console.WriteLine();
            Console.ReadKey();


        }

    }
}