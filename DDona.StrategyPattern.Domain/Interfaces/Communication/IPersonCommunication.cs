using DDona.StrategyPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Domain.Interfaces.Communication
{
    public interface IPersonCommunication
    {
        bool SendCommunication(Person person);
    }
}
