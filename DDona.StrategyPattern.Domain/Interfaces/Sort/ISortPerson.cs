using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Enum;
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
