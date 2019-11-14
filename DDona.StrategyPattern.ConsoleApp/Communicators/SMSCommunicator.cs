using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Interfaces.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.ConsoleApp.Communicators
{
    public class SMSCommunicator : IPersonCommunication
    {
        /*
         * Implementar todas as especificadades do SMS
         */
         
        public bool SendCommunication(Person person, Message message)
        {
            string phoneTo = person.PhoneNumber;
            string description = message.Description;

            // enviar SMS...
            // new SendSMS(phoneTo, description);
            return true;
        }
    }
}
