var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Garage garage = new Garage();
System.Console.WriteLine(garage.ShowAllCars().Count());

Group people = new Group();

foreach(Car c in garage.Cars) {
    System.Console.WriteLine(c.Rego);
}

foreach(Customer c in people.Customers) {
    System.Console.WriteLine($"{c.LicenceNo} \t\t {c.Name}");
}

app.MapGet("/", () => "Hello World!");

app.Run();
