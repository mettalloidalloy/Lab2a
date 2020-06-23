using System;

class MainClass {
  public static void Main (string[] args) {

  double farenheit;
  double celsius = 36;
  Console.WriteLine("Enter temperature in Celsius.");
  celsius = Convert.ToDouble(Console.ReadLine());
  farenheit = (celsius * 9 / 5) + 32;
  Console.WriteLine("Temperature in farenheit is: " + farenheit);

  if (farenheit < 32)
    {
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit.");     
    }
  else if (farenheit > 32 && farenheit < 212)
    {

    }
  
  else 
    {
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit.");
    }
  
  }
}