using System;

namespace Domain
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }
    }
}

