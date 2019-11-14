using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.StrategyPattern.Domain.Entities
{
    public class Message
    {   
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Important { get; private set; }

        public Message(string title, string description, bool important)
        {
            Title = title;
            Description = description;
            Important = important;
        }
    }
}
