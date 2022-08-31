namespace Ex2
{
    internal abstract class Animal
    {
        public abstract int Weight { get; set;}
        public abstract string Name { get; set; }
        public abstract void Show();
        public abstract void SetMe(int weight, string name);
        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        public Animal() { }
    }
    internal class Tiger : Animal
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }
        public Tiger() { }
        public Tiger(int weight, string name) : base(weight, name)
        {
            Weight = weight;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :" + Name + " Weight :" + Weight;
        }
        public override void SetMe(int weight, string name)
        {
           Weight = weight;
            Name = name;
        }

        public override void Show()
        {
            Name = "Tiger";
            Weight = 200;
            Console.WriteLine(ToString());
        }
    }
    internal class Lion : Animal
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }

        public Lion() { }
        public Lion(int weight, string name) : base(weight, name)
        {
            Weight = weight;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :" + Name + " Weight :" + Weight;
        }

        public override void SetMe(int weight, string name)
        {
            
            Weight = weight;
            Name = name;
        }

        public override void Show()
        {
            Name = "Lion";
            Weight = 100;
            Console.WriteLine(ToString());
        }


    }
    internal class Run
    {
        public static void Main(string[] cmd)
        {
            
            Lion lion = new Lion();
            lion.Show();
            
            Tiger tiger = new Tiger();
            tiger.Show();
            

        }
    }


}