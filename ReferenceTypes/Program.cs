using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean - value types (Değer Tip)
            int num1 = 10;
            int num2 = 20;

            num1 = num2;
            num2 = 999;

            Console.WriteLine(num1); //20

            Console.WriteLine("-----------------");

            //arrays,class,interface... - referance types (Referans Tip)
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 10, 20, 30 };

            array1 = array2;
            array2[0] = 999;

            Console.WriteLine(array1[0]); //999

            Console.WriteLine("-----------------");

            Person person1 = new Person();
            person1.Id = 1;
            person1.FirstName = "Tolga";
            person1.LastName = "Sözbir";

            Person person2 = new Person();
            person2 = person1;
            Console.WriteLine(person2.Id +" "+ person2.FirstName +" "+ person2.LastName);

            Console.WriteLine("-----------------");

            Employee employee = new Employee();
            employee.FirstName = "Bilo";

            Customer customer = new Customer();
            customer.Id = 2;
            customer.FirstName = "Levent";
            customer.LastName = "Sözbir";
            customer.CreditCardNumber = 19961980;
            

            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            Console.WriteLine("-----------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(person1);
            personManager.Add(employee);
            personManager.Add(customer);

            Console.ReadKey();
        }
    }
    //Base Class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
