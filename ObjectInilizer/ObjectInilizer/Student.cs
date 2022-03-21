using System;

namespace ObjectInilizer
{
    public class Student
    {
        int? _Id, _Class;
        string _Name;
        float? _Marks, _Fess;

        public int? Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int? Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public float? Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }
        public float? Fess
        {
            get { return _Fess; }
            set { _Fess = value; }
        }
        public override string ToString()
        {
            return "Id:" + _Id + "\nName:" + _Name + "\nClass:" + _Class + "\nMarks:" + _Marks + "\nFess:" + _Fess + "\n";
        }
    }
    internal class TestStudent
    {
        static void Main()
        {
            Student s = new Student { Id = 310, Name = "Siva", Class = 10, Marks = 550.00f, Fess = 1600.00f, };
            
            Student s1 = new Student { Id = 110, Name = "Lucky",  Marks = 550.00f, };
            Console.WriteLine(s);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
