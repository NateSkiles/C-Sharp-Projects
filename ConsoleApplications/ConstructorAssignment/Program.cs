using System;

namespace ConstructorAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a const variable.
            const string nateGreat = "Nate";
            // Create a variable using the keyword “var.”
            Console.WriteLine("Who is great?");
            var isGreat = false;
            // Chain two constructors together.
            Nate nate1 = new Nate(nateGreat);
            Nate nate2 = new Nate(nateGreat, isGreat);

            nate1.Say();
            nate2.Say();

            Console.ReadLine();
        }
    }

    public class Nate
    {
        // props
        public string Name { get; set; }
        public bool Great { get; set; }

        public Nate(string name) : this(name, true) { }
        public Nate(string name, bool isGreat)
        {
            Great = isGreat;
            Name = name;
        }
         public void Say()
        {
            if (this.Great)
            {
                Console.WriteLine("{0} is great!", this.Name);
            }
            else
            {
                Console.WriteLine("{0} is not great", this.Name);
            }
        }
    }
}
