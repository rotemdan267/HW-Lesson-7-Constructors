using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_7_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q7

            //Car c = new Car("Ford");
            //Console.WriteLine(c.GetBrand());

            #endregion

            #region Q8

            //ConsolePlus cp = new ConsolePlus();
            //Console.WriteLine();
            //ConsolePlus cp1 = new ConsolePlus("second constructor");
            //Console.WriteLine();
            //ConsolePlus cp2 = new ConsolePlus(2, 4, "third constructor");

            #endregion

            #region Q9

            //Console.WriteLine("How many people do you want?");
            //int num = int.Parse(Console.ReadLine());
            //Person[] people = new Person[num];
            //string[] names = new string[num];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Enter name:");
            //    names[i] = Console.ReadLine();
            //    people[i] = new Person(names[i]);
            //}

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Name no. {0}: {1}", i + 1, people[i]._name);
            //}

            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i]._name = null;
            //    names[i] = null;
            //}

            //int[] ages = new int[num];

            //Random rand = new Random();

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine("Enter name:");
            //    ages[i] = rand.Next(99) + 1;
            //    names[i] = Console.ReadLine();
            //    people[i] = new Person(names[i], ages[i]);
            //}

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Name: \"{0}\". Age: {1}", people[i]._name, people[i]._age);
            //}

            #endregion

            #region Q10

            //Book b1 = new Book();
            //Console.WriteLine("What is the name of the book?");
            //b1.name = Console.ReadLine();
            //Console.WriteLine("Genre?");
            //b1.genre = Console.ReadLine();
            //Console.WriteLine("How many pages?");
            //b1.NumOfPages = int.Parse(Console.ReadLine());

            //Book b2 = new Book(b1);

            //Console.WriteLine(b2.name + " " + b2.genre + " " + b2.NumOfPages);

            #endregion

            #region Class Exercise

            //Animal a1 = new Animal();
            //Animal a2 = new Animal();

            //Animal a3 = new Animal("Cat", 4);
            //Animal a4 = new Animal("Dog", 3);

            #endregion

            Console.ReadLine();
        }
    }
    class Car
    {
        public string brand;

        public Car(string brand1)
        {
            brand = brand1;
        }
        public string GetBrand()
        {
            return brand;
        }
    }

    class ConsolePlus
    {
        public ConsolePlus()
        {
            Console.WriteLine("default");
        }
        public ConsolePlus(string str) : this()
        {
            Console.WriteLine(str);
        }
        public ConsolePlus(int n1, int n2, string str1) : this(str1)
        {
            Console.WriteLine(n1 + n2);
        }
    }

    class Person
    {
        public string _name;
        public int _age;
        public Person(string name)
        {
            _name = name;
        }
        public Person(string name, int age) : this(name)
        {
            _age = age;
        }
    }

    class Book
    {
        public int NumOfPages;
        public string name;
        public string genre;
        public Book()
        {

        }
        public Book(int pages, string name1, string genre1)
        {
            NumOfPages = pages;
            name = name1;
            genre = genre1;
        }

        public Book(Book b) : this(b.NumOfPages, b.name, b.genre)
        {
        }
    }

    class Animal
    {
        public string type;
        public int age;
        public bool areThereCubs;
        public Animal()
        {

        }
        public Animal(int ag) : this()
        {

        }
        public Animal(string typ, int ag)
        {
            type = typ;
            age = ag;
        }
        public Animal(Animal[] zoo)
        {
            bool flag = true;
            int sum = 0;
            for (int i = 0; i < zoo.Length; i++)
            {
                if (zoo[i].type != null)
                {
                    flag = false;
                    break;
                }
                sum += zoo[i].age;
            }
            if (flag)
            {
                Console.WriteLine("The array isn't booted");
                areThereCubs = false;
            }
            if (sum > 0)
            {
                areThereCubs = true;
            }
            else areThereCubs = false;
        }
        public Animal(string typ, int ag, Animal[] zoo) : this(ag)
        {

        }
        public Animal(string typ, int ag, bool cubs)
        {
            type = "Lion";
            Random rand = new Random();
            if (ag == 0)
            {
                age = rand.Next(29) + 1;
            }
            else age = 0;
            areThereCubs = cubs;
        }
    }
}
