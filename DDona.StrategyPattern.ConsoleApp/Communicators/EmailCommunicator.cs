using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Interfaces.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.ConsoleApp.Communicators
{
    public class EmailCommunicator : IPersonCommunication
    {
        /*
         * Implementar todas as especificadades do Email
         */
         
        public bool SendCommunication(Person person, Message message)
        {
            string emailTo = person.Email;
            string title = message.Title;
            string description = message.Description;

            // enviar email...
            // new SendEmail(emailTo, title, description);
            return true;
        }
    }
}
