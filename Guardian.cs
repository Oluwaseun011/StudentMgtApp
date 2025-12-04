using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp
{
    public class Guardian
    {


    
        public int Id{get;set;}
        public string Email{get;set;} = default!;
        public string Address{get;set;} = default!;
        public string PhoneNumber{get;set;} = default!;
        public string FirstName{get;set;} = default!;
        public string LastName{get;set;} = default!;

        public Guardian(int id,string firstName,string lastName,string email,string address,string phonenumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            PhoneNumber = phonenumber;
        }

    }
}