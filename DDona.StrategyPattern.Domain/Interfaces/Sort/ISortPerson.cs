using DDona.StrategyPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Domain.Interfaces.Sort
{
    public interface ISortPerson
    {
        IList<Person> DoSort(IList<Person> people);
    }
}
