using RentCars.Types;
using RentCars.Models;

namespace RentCars;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância de Vehicle
        Vehicle vehicle = new Vehicle
        {
            Brand = "Volkswagen",
            Model = "Fusca",
            Price = 10000m,
            Fuel = FuelType.Gasoline,
            EngineCapacity = 1500,
            Year = 1970,
            PricePerDay = 70.0,
            IsRented = false,
            MainColor = new Color() { Name = "Preto", Hex = "#000000" }
        };

        // Criando uma instância de PhysicalPerson
        PhysicalPerson person = new PhysicalPerson
        {
            Name = "Joãozinho",
            Email = "joao@gmail.com",
            Address = "Rua Antonio Olinda, 204",
            Contact = "88 999554454",
            CPF = "011.787.456-65"
        };

        // Criando uma instância de Rent
        int daysRented = 10;
        Rent rent = new Rent(vehicle, person, daysRented);

        // Exibindo detalhes do aluguel
        Console.WriteLine($"Aluguel confirmado para {rent.Person.Name}");
        Console.WriteLine($"Veículo: {rent.Vehicle.Model} ({rent.Vehicle.Year})");
        Console.WriteLine($"Cor: {rent.Vehicle.MainColor.Name}");
        Console.WriteLine($"Período: {daysRented} dias");
        Console.WriteLine($"Preço total: {rent.Price.ToString("C")}");
    }
}
