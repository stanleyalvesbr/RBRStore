using System;
using System.Collections.Generic;
using RbrStore.Domain.StoreContext.ValueObjects;
using System.Linq;

namespace RbrStore.Domain.StoreContext.Entities
{
    public class Customer
  {
     // S O L I D

    // S - Single Responsability Principal (Princípio da Responsabilidade Única)

    // O - Open Closed Principal 
    

     private readonly IList<Address> _addresses; //sempre colocar _ quando for variável privada
      public Customer(
            Name name,
            Document document,
            Email email,
            string phone,
            string address)
      {
        Name = name;
        Document = document;
        Email = email;
        Phone = phone;
        _addresses = new List<Address>();
          
      }

       public Name Name {get; private set;}
       public Document Document { get; private set; }
       public Email Email { get; private set; }
       public string Phone { get; private set;}
       public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

       public void AddAddress(Address address)
       {
         // Validar o endereço
         // Adicionar o endereço
         _addresses.Add(address);
       }

       public override string ToString()
       {
          return  Name.ToString();
       }
       
  }
  
}