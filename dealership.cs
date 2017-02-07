using System;
using System.Collections.Generic;

public class Car
{
  private string _make;
  private string _model;
  private int _year;

  public string GetMake()
  {
    return _make;
  }
  public void SetMake(string newMake)
  {
    _make = newMake;
  }
  public string GetModel()
  {
    return _model;
  }
  public void SetModel(string newModel)
  {
    _model = newModel;
  }
  public int GetYear()
  {
    return _year;
  }
  public void SetYear(int newYear)
  {
    _year = newYear;
  }
}

class Dealership
{
  public static List<Car> Inventory = new List<Car> {};
  public static void Main()
  {
    Console.WriteLine("What would you like to do? --> [Add] a car/[View] all cars");
    string userQuery = Console.ReadLine().ToLower();
    if (userQuery == "add")
    {
      AddCar();
    }
    else if (userQuery == "view")
    {
      PrintCar(Inventory);
    }
    Main();
  }
  public static void AddCar()
  {
    Car newCar = new Car();
    Console.WriteLine("What is the make of the car?");
    string newMake = Console.ReadLine();
    newCar.SetMake(newMake);
    Console.WriteLine("What is the model of the car?");
    string newModel = Console.ReadLine();
    newCar.SetModel(newModel);
    Console.WriteLine("What is the year of the car?");
    int newYear = Int32.Parse(Console.ReadLine());
    newCar.SetYear(newYear);
    Inventory.Add(newCar);
  }
  public static void PrintCar(List<Car> inventory)
  {
    foreach (Car item in inventory)
    {
      string carMake = item.GetMake();
      string carModel = item.GetModel();
      string carYear = item.GetYear().ToString();
      Console.WriteLine("Make: " + carMake + "  Model: " + carModel + "  Year: " + carYear);
    }
  }
}
