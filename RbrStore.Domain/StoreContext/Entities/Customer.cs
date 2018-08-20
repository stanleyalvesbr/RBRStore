using System;

namespace RbrStore.Domain.StoreContext.Entities
{
  public class Customer
  {
     // S O L I D

    // S - Single Responsability Principal (Princípio da Responsabilidade Única)

    // O - Open Closed Principal 
    
      public Customer(
            string firstName,
            string lastName,
            string document,
            string email,
            string phone,
            string address)
      {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
        Phone = phone;
        Address = address;
          
      }
       public string FirstName { get; private set; }  

       public string LastName { get; private set; } 

       public string Document { get; private set; }

       public string Email { get; private set; }

       public string Phone { get; private set;}

       public string Address { get; private set; }


       public override string ToString()
       {
             return $"{FirstName} {LastName}";
       }
  }
  
}