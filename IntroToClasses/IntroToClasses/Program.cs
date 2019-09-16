using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.CompanyFactory.DepartmentFactory.Departments;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractFactory;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.AbstractProduct;
using IntroToClasses.Common_Design_Patterns.Factory_Design_Pattern.DocumentFactory.ConcreteFactory;
using IntroToClasses.Inheritence;
using System;
using System.Collections.Generic;

namespace IntroToClasses
{
    class Program
    {    /// <summary>
         /// In this lesson we will discuss classes.
         /// 
         /// We will discuss what classes are made from, why we use them
         /// and how to use them effectively.
         /// 
         /// We will discuss "naming conventions" for classes, fields, properties
         /// and methods.
         /// 
         /// We will discuss "encapsulation" and the access keywords:
         ///     public
         ///     internal
         ///     private
         ///     
         /// We will discuss "construction" with the constructor method
         /// 
         /// We will discuss "overloading" methods
         /// </summary>
         /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region Polymorphism

            //// This is an example of using "base" class to create a list of
            //// "Animals", however, we will not create an "Animal" class,
            //// but will create the "child" or "inherited" children.
            //List<Animal> animals = new List<Animal>();

            //// By using the base class for the list, we can store many different types
            //// of "animal" in the list, without them all being the same.
            //animals.Add(new Cat());
            //animals.Add(new Dog());
            //animals.Add(new Horse());


            //// Also, we can "iterate" through the list using the "base" class
            //// methods and execute them on every "child" class without having to 
            //// worry about what kind of child class it is. They all have the same method
            //// when we use the base class. This is called polymorphism.
            //foreach (Animal animal in animals)
            //{
            //    animal.MakeAnimalSound();
            //}

            #endregion

            #region Design Patterns

            #region Adapter Pattern

            //// Non-adapted chemical compound
            //Compound unknown = new Compound("Unknown");
            //unknown.Display();

            //// Adapted chemical compounds
            //Compound water = new RichCompound("Water");
            //water.Display();

            //Compound benzene = new RichCompound("Benzene");
            //benzene.Display();

            //Compound ethanol = new RichCompound("Ethanol");
            //ethanol.Display();

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #region Factory Pattern

            //// Note: constructors call Factory Method
            //AbstractDocumentFactory[] documents = new AbstractDocumentFactory[2];

            //documents[0] = new ConcreteResumeFactory();
            //documents[1] = new ConcreteReportFactory();

            //// Display document pages
            //foreach (AbstractDocumentFactory document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + "--");
            //    foreach (AbstractPageProduct page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}

            //// Wait for user
            //Console.ReadKey();


            Company[] companies = new Company[1];
            companies[0] = new SoftwareCompany("My Awesome Software Company", new PayRollSystem());

            foreach (Company company in companies)
            {
                Console.WriteLine($"Company Name: {company.CompanyName}");
                foreach (Department department in company.Departments)
                {
                    Console.WriteLine($"    Department: {department.DepartmentName}");
                }
                Console.WriteLine();

                Console.WriteLine("Let's pay our employees");
                Console.WriteLine();
                company.PayEmployees();
            }

            #endregion

            #region Singleton Pattern

            //LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            //LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            //// Same instance?
            //if (b1 == b2 && b2 == b3 && b3 == b4)
            //{
            //    Console.WriteLine("Same instance\n");
            //}

            //// Load balance 15 server requests
            //LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            //for (int i = 0; i < 15; i++)
            //{
            //    string server = balancer.Server;
            //    Console.WriteLine("Dispatch Request to: " + server);
            //}

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #region Strategy Pattern

            //// Two contexts following different strategies
            //StrategySortedList studentRecords = new StrategySortedList();

            //studentRecords.Add("Samual");
            //studentRecords.Add("Jimmy");
            //studentRecords.Add("Sandra");
            //studentRecords.Add("Vivek");
            //studentRecords.Add("Anna");

            //studentRecords.SetSortStrategy(new QuickSort());
            //studentRecords.Sort();

            //studentRecords.SetSortStrategy(new ShellSort());
            //studentRecords.Sort();

            //studentRecords.SetSortStrategy(new MergeSort());
            //studentRecords.Sort();

            //// Wait for user
            //Console.ReadKey();

            #endregion

            #endregion
        }
    }
}
