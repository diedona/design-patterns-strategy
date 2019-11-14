using DDona.StrategyPattern.ConsoleApp.Communicators;
using DDona.StrategyPattern.ConsoleApp.Sorters;
using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Enum;
using DDona.StrategyPattern.Domain.Interfaces.Communication;
using DDona.StrategyPattern.Services;
using System;
using System.Collections.Generic;

namespace DDona.StrategyPattern.ConsoleApp
{
    class Program
    {
        private static Dictionary<PreferredCommunication, IPersonCommunication> _communicators =
            new Dictionary<PreferredCommunication, IPersonCommunication>()
            {
                {PreferredCommunication.Email, new EmailCommunicator() },
                {PreferredCommunication.SMS, new SMSCommunicator() },
                {PreferredCommunication.Tribe, new TribeCommunicator() }
            };

        static void Main(string[] args)
        {
            PersonService personService = new PersonService();
            personService.SetSortStrategy(new PeopleBirthDateSorter(SortDirection.Asc));
            var people = personService.GetPeople();

            foreach (var person in people)
            {
                // recupera a estratégia concreta de comunicação do dicionário
                personService.SetCommunicationStrategy(_communicators[person.PreferredCommunication]);
                personService.SendCommunication(person, new Message("EAE", "Td bão?", false));
            }
        }
    }
}
