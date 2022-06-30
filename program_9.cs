using System;

class Program
{
    public struct Employee
    {
        public int id;
        public double salary;

        public Employee(int id, double salary)
        {
            this.id = id;
            this.salary = salary;
        }

        public readonly void Display()
        {
            Console.WriteLine($"id: {id}\nsalary: {salary}\n");
        }
    }

    public static void Main()
    {
        Employee emp1 = new Employee(4001, 5607);
        Employee emp2 = new Employee(4002, 7801);
        Employee emp3 = new Employee(4003, 3560);

        emp1.Display();
        emp2.Display();
        emp3.Display();
    }
}
