using System;
using RbrStore.Domain.StoreContext.ValueObjects;

namespace RbrStore.Domain.StoreContext.Entities
{
  public class Customer
  {
     // S O L I D

    // S - Single Responsability Principal (Princípio da Responsabilidade Única)

    // O - Open Closed Principal 
    
      public Customer(
            Name name,
            Document document,
            string email,
            string phone,
            string address)
      {
        Name = name;
        Document = document;
        Email = email;
        Phone = phone;
        Address = address;
          
      }

       public Name Name {get; private set;}
       public Document Document { get; private set; }

       public string Email { get; private set; }

       public string Phone { get; private set;}

       public string Address { get; private set; }

       public override string ToString()
        {
          return  Name.ToString();
        }
       
  }
  
}