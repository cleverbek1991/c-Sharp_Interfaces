using System;
using System.Linq;
using System.Collections.Generic;

public class JetSki : IWaterVehicle, IVehicle
{
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Auto";
    public double EngineVolume { get; set; } = 4.8;
    public double MaxWaterSpeed { get; set; } = 78.8;
    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Submarine : IWaterVehicle, IVehicle
{
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 100;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 123.43;
    public double MaxWaterSpeed { get; set; } = 100.23;
    public void Drive()
    {
        Console.WriteLine("A submarine (or simply sub) is a watercraft capable of independent operation underwater.");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IGroundVehicle, IVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 222.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Quadro4 : IGroundVehicle, IVehicle
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 2.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("QUADRO4 is the first Four wheel scooter worldwide, for a unique level of safety combined with a higher degree of freedom, performance and fun.");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IAirVehicle
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 6;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxWaterSpeed { get; set; } = 21.3;
    public double MaxLandSpeed { get; set; } = 11.2;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
    throw new NotImplementedException();
    }

    public void Fly()
    {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming ... of the Sun");
    }
    public void Start()
    {
    throw new NotImplementedException();
    }
    public void Stop()
    {
    throw new NotImplementedException();
    }
}

public class Helicopter : IAirVehicle, IVehicle
{
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 6;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 131.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
        Console.WriteLine("A helicopter is a type of rotorcraft in which lift and thrust are supplied by rotors.");
    }
    public void Start()
    {
    throw new NotImplementedException();
    }
    public void Stop()
    {
    throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IAirVehicle> airVehicle = new List<IAirVehicle>();
        Helicopter something = new Helicopter();
        Cessna some = new Cessna();

        airVehicle.Add(something);
        airVehicle.Add(some);
    
        // With a single `foreach`, have each vehicle Fly()
        foreach (var item in airVehicle)
        {
            item.Fly();
        }


        // Build a collection of all vehicles that operate on roads
        List<IGroundVehicle> groundVehicle = new List<IGroundVehicle>()
        {
            new Quadro4(),
            new Motorcycle()
        };
        // With a single `foreach`, have each road vehicle Drive()
        foreach (var i in groundVehicle)
        {
            i.Drive();
        }


        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> waterVehicle = new List<IWaterVehicle>()
        {
            new JetSki(),
            new Submarine()
        };
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var item in waterVehicle)
        {
            item.Drive();
        }
    }

}
