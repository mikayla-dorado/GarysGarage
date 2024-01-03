namespace Garage;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram zooms right by you!");
    }
}