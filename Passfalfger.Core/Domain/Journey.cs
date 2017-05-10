using System;
using System.Collections.Generic;

namespace Passfalfger.Core.Domain
{
    public class Journey
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; }
    }
}