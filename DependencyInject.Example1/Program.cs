using System;
namespace DependencyInjection;
//Deoendency injection (DI) is of three types : 1. Constructor DI        2. Method DI        3. Property DI

// Injector class : injects the service class objects in the client class
public class Injector
{
    public static void Main()
    {
        Client objMahindra = new Client(new MahindraService());
        Client objTata = new Client(new TataService());
    }
}

// Client class : a class that is dependent on the service class
public class Client
{
    private IService iService;

    public Client(IService _iService)
    {
        this.iService = _iService;
        this.iService.getCarName();
        this.iService.getCarTopSpeed();
    }
}

// Interface implementation
public interface IService
{
    void getCarName();
    void getCarTopSpeed();
}

// Service class 1
public class MahindraService: IService
{
    public void getCarName()
    {
        Console.WriteLine("Mahindra XUV");
    }

    public void getCarTopSpeed()
    {
        Console.WriteLine("Top Speed of Mahindra XUV: 200 kmph");
    }
}

// Service Class 2
public class TataService: IService
{
    public void getCarName()
    {
        Console.WriteLine("Tata Nexon");
    }

    public void getCarTopSpeed()
    {
        Console.WriteLine("Top Speed of Tata Nexon: 160 kmph");
    }
}