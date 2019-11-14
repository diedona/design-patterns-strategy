using DDona.StrategyPattern.Domain.Enum;
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
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Tribe { get; private set; }
        public PreferredCommunication PreferredCommunication { get; private set; }

        public Person(string fullName, DateTime birthDate, string email, string phoneNumber, string tribe, PreferredCommunication communication = PreferredCommunication.Email)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
            PreferredCommunication = communication;
            Tribe = tribe;

            if (this.BirthDate > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("BirthDate", "Future dates not allowed");
            }
        }
    }
}
