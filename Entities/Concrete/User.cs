﻿using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public User(int userId, string firstName, string lastName, string email, string password)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public User()
        {

        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Customer? Customers { get; set; } = null;
    }
}
