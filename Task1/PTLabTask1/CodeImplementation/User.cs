﻿using Data.API;


namespace Data.CodeImplementation
{
    internal class User : IUser
    {
        public User(int id, string firstName, string lastName, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string Address { get; set; }
    }
}


