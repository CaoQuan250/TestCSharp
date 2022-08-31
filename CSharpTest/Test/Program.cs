using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal abstract class tbase
    {
        public abstract int Weight
        {
            get; set;
        }
        public abstract string Name { get; set; }
        public abstract void Show();
        public abstract void SetMe(int weight, string name);
        public tbase(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        public tbase() { }
    }
    internal class Tiger : tbase
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
            Console.WriteLine("Fix Weight , Fix Name :");
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
    internal class Lion : tbase
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
            Console.WriteLine("Fix Weight , Fix Name :");
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
    internal class program
    {
        public static void Main(string[] cmd)
        {
            Console.WriteLine("------------");
            Lion lion = new Lion();
            lion.Show();
            Console.WriteLine("------------");
            Tiger tiger = new Tiger();
            tiger.Show();
            Console.WriteLine("------------");

        }
    }
}


