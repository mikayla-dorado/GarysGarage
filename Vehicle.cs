using Microsoft.Win32.SafeHandles;

namespace Garage;
public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} vehicle turns {direction}");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} vehicle fully stops.");
    }
}