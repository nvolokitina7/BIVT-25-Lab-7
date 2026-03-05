namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Profession prof1 = new Profession("electric", 50);
            Teacher teach1 = new Teacher("math teacher", 25, "mathematics");
            Profession hiddenTeacher = new Teacher("another teacher", 20, "informatics");

            Profession[] professions = new Profession[] {teach1, hiddenTeacher };
            for (int i = 0; i < professions.Length; i++)
            {
                if (professions[i] is Teacher)
                {
                    Teacher t = professions[i] as Teacher;
                    Console.WriteLine(t.Sub);
                }
            }

            for (int i = 0; i < professions.Length; i++)
            {
                Teacher t = professions[i] as Teacher;
                if (t!=null)
                {
                    Console.WriteLine(t.Sub);
                }
            }

            //Profession prof2 = new Teacher(); сработает
            //Teacher teach2 = new Profession();  не сработает

            //prof1.Greetings();
            //prof1.Print();
            //teach1.Greetings();
            //teach1.Print();

            //prof1.Hi();
            //prof1.Hellochild();
            //teach1.Hi();
            //teach1.Hellochild();

            hiddenTeacher.Greetings();
            hiddenTeacher.Print();

        }
    }
    public abstract class Profession            // от абстр. классов нельзя создавать экземпляры!!!
    {
        protected string _name;
        protected int _salary;
        public virtual string Name => Name;
       public abstract string Abstr { get; }
        public Profession(string name, int salary)
        {
            _name = name; _salary = salary;
        }
        public virtual void Greetings()
        { Console.WriteLine("I do not know my profession."); }
        public void Print()
        { Console.WriteLine($"Profession: {_name}, {_salary}"); }
        public void Hi()
        { Console.WriteLine("Hi, children!"); }
        public void Hellochild()
        { Console.WriteLine($"Hello, {_name}"); }

        public abstract void Bye();
    }

    public class Teacher : Profession
    {
        private string _sub; private bool _hasClass; public string Sub => _sub;
        public override string Abstr => "ghujk";
        public Teacher(string name1, int salary1, string sub) : base(name1, salary1)
        {
            _salary *= 5;
            _sub = sub;
            _hasClass = false;
        }
        public Teacher(string name, int salary, string sub, bool hasClasses) : this(name, salary, sub)
        {
            _hasClass = hasClasses;
        }
        public override void Greetings()     //Переопределение
        { Console.WriteLine("I am a teacher."); }
        public new void Print()    //Сокрытие
        { Console.WriteLine($"Teacher: {_name}, {_salary}, {_sub}"); }
        public override void Bye()
        {
            Console.WriteLine("Bye!");
        }
    }

}
