using DDona.StrategyPattern.Domain.Entities;
using DDona.StrategyPattern.Domain.Interfaces.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.ConsoleApp.Communicators
{
    public class TribeCommunicator : IPersonCommunication
    {
        /*
         * Implementar todas as especificadades do Sinal de Fumaça
         */
         
        public bool SendCommunication(Person person, Message message)
        {
            string tribeTo = person.Tribe;
            string personTo = person.FullName;

            // enviar sinal...
            // new DispatchSmoke(tribeTo, personTo);
            return true;
        }
    }
}
