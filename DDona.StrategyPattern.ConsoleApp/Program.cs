using DDona.StrategyPattern.ConsoleApp.Communicators;
using DDona.StrategyPattern.ConsoleApp.Sorters;
using DDona.StrategyPattern.Domain.Enum;
using DDona.StrategyPattern.Services;
using System;

namespace DDona.StrategyPattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new PersonService(new PeopleNameSorter(SortDirection.Asc), new EmailCommunicator());
            foreach (var person in personService.GetPeople())
            {
                Console.WriteLine($"{person.Id} - {person.FullName.PadRight(30,' ')} - {person.BirthDate.ToShortDateString()}");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            personService.SetSortStrategy(new PeopleBirthDate(SortDirection.Desc));
            foreach (var person in personService.GetPeople())
            {
                Console.WriteLine($"{person.Id} - {person.FullName.PadRight(30, ' ')} - {person.BirthDate.ToShortDateString()}");
            }
        }
    }
}
