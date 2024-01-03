namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla screehches past you! BYEEEEEE");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla drifts {direction}");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla comes to a hault.");
    }
}