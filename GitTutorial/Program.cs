using System;

namespace GitTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application();
            Console.ReadKey();
        }
    }


    public class Application
    {

        public Application()
        {
            var MohamadLove = WhoIsMyLove(new Human() { Name = "Mohamad", LastName = "Ravaei" });

            Console.WriteLine("Who Is Mohamad`s Love : \n");
            Console.WriteLine(MohamadLove.ToString());
        }

        public Human WhoIsMyLove(Human human)
        {
            if(human.Name == "Mohamad" && human.LastName == "Ravaei") {
                return new Human() { Name = "ZiZi", LastName = "Mortazavi", Age = 25 };
            }
            else
            {
                throw new Exception("Other people are not my business :)");
            }
            
            
        }

        public class Human
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return "Name Is : " + this.Name + " And The LastName Is : " + this.LastName;
            }
        }

    }

    
}
