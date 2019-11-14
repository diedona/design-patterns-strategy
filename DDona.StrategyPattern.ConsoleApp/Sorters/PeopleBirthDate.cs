using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Enum;
using DDona.StrategyPattern.Domain.Interfaces.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.StrategyPattern.ConsoleApp.Sorters
{
    public class PeopleBirthDate : ISortPerson
    {
        private SortDirection _sortDirection;

        public PeopleBirthDate(SortDirection direction)
        {
            _sortDirection = direction;
        }

        public IList<Person> DoSort(IList<Person> people)
        {
            if (_sortDirection == SortDirection.Asc)
            {
                return people.OrderBy(x => x.BirthDate).ToList();
            }
            else
            {
                return people.OrderByDescending(x => x.BirthDate).ToList();
            }
        }
    }
}
