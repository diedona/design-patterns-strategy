using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Person(Guid id, string fullName, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;

            if(this.BirthDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("BirthDate", "Future dates not allowed");
            }
        }
    }
}
