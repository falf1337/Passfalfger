using System;

namespace Passfalfger.Core.Domain
{
    public class Passenger
    {
        public Guid Id { get; set; }
        public Guid UserId { get; protected set; }
        public Node Address  { get; protected set; }
    }
}