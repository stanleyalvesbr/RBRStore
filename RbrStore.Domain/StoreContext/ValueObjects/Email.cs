using System;
using RbrStore.Domain.StoreContext.ValueObjects;

namespace RbrStore.Domain.StoreContext.Entities
{
  public class Email
  {
      public Email(string address)
      {
          Address = address;
      }
      public string Address { get; private set; }   

      public override string ToString()
      {
          return Address;
      }             
  }


}