using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] commandArguments = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                try
                {
                    string firstName = commandArguments[0];
                    string lastName = commandArguments[1];
                    int age = int.Parse(commandArguments[2]);
                    decimal salary = decimal.Parse(commandArguments[3]);

                    Person person = new Person(firstName, lastName, age, salary);
                    people.Add(person);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Team team = new Team("SoftUni");

            foreach (var person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
        }
    }
}