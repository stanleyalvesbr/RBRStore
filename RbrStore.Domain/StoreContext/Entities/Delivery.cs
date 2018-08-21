using System;
using RbrStore.Domain.StoreContext.Enums;


namespace RbrStore.Domain.StoreContext.Entities
{
  public class Delivery 
  {
    public Delivery(DateTime estimatedDeliveryDate)
    {
        CreateDate = DateTime.Now;
        EstimatedDeliveryDate = estimatedDeliveryDate;
        Status = EDelivaryStatus.Waiting;
    }
    public DateTime CreateDate { get; private set; }
    public DateTime EstimatedDeliveryDate { get; private set; }
    public EDelivaryStatus Status { get; private set; }
       
    }
  
}