using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;
        Status = RentStatus.Confirmed;
        Vehicle.IsRented = true;

        Price = vehicle.PricePerDay * daysRented;
        if (Person.GetType() == typeof(LegalPerson))
        {
            double discount = 0.1;
            Price -= discount;
        }

        Person.Debit = Price;
    }

    public void Cancel()
    {
        Vehicle.IsRented = false;
        Person.Debit += Price;
        Status = RentStatus.Canceled;
    }

    public void Finish()
    {
        Status = RentStatus.Finished;
    }
}