using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Enum;
using DDona.StrategyPattern.Domain.Interfaces.Communication;
using DDona.StrategyPattern.Domain.Interfaces.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Services
{
    public class PersonService
    {
        private ISortPerson _sortStrategy;
        private IPersonCommunication _communicationStrategy;
        private IList<Person> _data;

        public PersonService(ISortPerson sortStrategy, IPersonCommunication communicationStrategy)
        {
            _sortStrategy = sortStrategy;
            _communicationStrategy = communicationStrategy;
            _data = GeneratePeople();
        }

        public void SetSortStrategy(ISortPerson newSortStrategy)
        {
            _sortStrategy = newSortStrategy;
        }

        public void SetCommunicationStrategy(IPersonCommunication newCommunicationStrategy)
        {
            _communicationStrategy = newCommunicationStrategy;
        }

        public IList<Person> GetPeople()
        {
            return _sortStrategy.DoSort(_data);
        }

        public bool SendCommunication(Person person, Message message)
        {
            return _communicationStrategy.SendCommunication(person, message);
        }

        #region [ FAKE DATA FOR DEMO ]

        private IList<Person> GeneratePeople()
        {
            return new List<Person>()
            {
                new Person("Diego Doná", new DateTime(1989,6,19), "diego.dona@mundo.com.br", "+55897775654", "East Ride"),
                new Person("Luis Inácio", new DateTime(1967,2,21), "teste@mundo.com.br", "+92984984", "West Ride", PreferredCommunication.SMS),
                new Person("Aécio Neves", new DateTime(1983,1,15), "vixi.po@mundo.com.br", "+65465456", "East Ride"),
                new Person("Alberta Vidima", new DateTime(1977,8,5), "arberta@mundo.com.br", "+874456363", "West Ride"),
                new Person("Luiza Albertina", new DateTime(1991,10,30), "canada@mundo.com.br", "+2316586", "KimmingKnow"),
                new Person("Lucas Colombini", new DateTime(1984,11,28), "lucao.cols@mundo.com.br", "+357565432", "ZigZigZow", PreferredCommunication.Tribe),
                new Person("Danilo Rupert", new DateTime(1998,10,14), "dandan22@mundo.com.br", "+15387485", "ZigZigZow", PreferredCommunication.Tribe),
            };
        }

        #endregion
    }
}
