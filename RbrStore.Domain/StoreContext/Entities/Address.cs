using System;


namespace RbrStore.Domain.StoreContext.Entities
{
    public class Address
    {
        public Address( 
            string street,
            string number,
            string complement,
            string district,
            string city,
            string state,
            string country,
            string zipcode,
            EAddressType type )
        {
           Street = street;
           Number = number;
           Complement = complement;
           District = district;
           City = city;
           State = state;
           Country = country;
           ZipCode = zipcode;
           Type = type;

        }
           public string Street { get; set; }  
           public string Number { get; set; }
           public string Complement { get; set; }
           public string District { get; set; }
           public string City { get; set; }
           public string State { get; set; }
           public string Country { get; set; }  
           public string ZipCode { get; set; }
           public EAddressType Type { get; set; }


           public override string ToString()
           {
               return $"{Street}, {Number}, - {City}/{State}" ;
           }


    }
   


}