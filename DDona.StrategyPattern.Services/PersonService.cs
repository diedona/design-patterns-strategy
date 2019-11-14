using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Interfaces.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Services
{
    public class PersonService
    {
        private ISortPerson _sortStrategy;
        private IList<Person> _data;

        public PersonService(ISortPerson sortStrategy)
        {
            _sortStrategy = sortStrategy;
            _data = GeneratePeople();
        }

        public void SetStrategy(ISortPerson newSortStrategy)
        {
            _sortStrategy = newSortStrategy;
        }

        public IList<Person> GetPeople()
        {
            return _sortStrategy.DoSort(_data);
        }

        #region [ FAKE DATA FOR DEMO ]

        private IList<Person> GeneratePeople()
        {
            return new List<Person>()
            {
                new Person(Guid.NewGuid(), "Diego Doná", new DateTime(1989,6,19)),
                new Person(Guid.NewGuid(), "Luis Inácio", new DateTime(1967,2,21)),
                new Person(Guid.NewGuid(), "Aécio Neves", new DateTime(1983,1,15)),
                new Person(Guid.NewGuid(), "Alberta Vidima", new DateTime(1977,8,5)),
                new Person(Guid.NewGuid(), "Luiza Albertina", new DateTime(1991,10,30)),
                new Person(Guid.NewGuid(), "Lucas Colombini", new DateTime(1984,11,28)),
                new Person(Guid.NewGuid(), "Danilo Rupert", new DateTime(1998,10,14)),
            };
        }

        #endregion
    }
}
