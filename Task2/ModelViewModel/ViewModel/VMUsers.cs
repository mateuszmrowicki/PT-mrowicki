﻿
namespace ModelViewModel.ViewModel
{
    public class VMUsers : PropertyChange
    {
        private int id;
        private string firstname;
        private string lastname;
        private string address;

        public VMUsers()
        {

        }

        public VMUsers(int iD, string firstName, string lastName, string addresS)
        {
            id = iD;
            firstname = firstName;
            lastname = lastName;
            address = addresS;
        }

        public int Id
        {
            get => id;

            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string firstName
        {
            get => firstname;
            set
            {
                firstname = value;

                OnPropertyChanged(nameof(firstName));
            }
        }
        public string lastName
        {
            get => lastname;
            set
            {
                lastname = value;

                OnPropertyChanged(nameof(lastName));
            }
        }
        public string Address
        {
            get => address;
            set
            {
                address = value;

                OnPropertyChanged(nameof(Address));
            }
        }
    }
}
