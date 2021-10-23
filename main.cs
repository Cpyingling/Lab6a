/*Author Charlie Yingling                                   10/6/2021
Write code using an array to store 7-day average temperatures of a city.
*/
using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
  //Store in an array called Celsius.
double[] Celcius = new double[7];
double[] Fahrenheit = new double[7];
int i;
    for (i = 0; i < 7; i++) { 
      //Get the average temperature as input in Celsius.
  Console.WriteLine("Enter temperature in Celcius: ");
     Celcius[i] = Convert.ToInt32(Console.ReadLine());
     Fahrenheit[i] = (Celcius[i] * 9 / 5) + 32; 
    }
      //Store in another array called Fahrenheit.
/*double[] Fahrenheit = new double[7];
    for (i = 0; i < 7; i++) { 
      //Convert temperature to Fahrenheit.
  Fahrenheit[i] = (Celcius[i] * 9 / 5) + 32; 
}*/
      //Sort the Fahrenheit array in descending order.
    Array.Sort(Fahrenheit);
    Array.Reverse(Fahrenheit);
      //Then using a foreach loop, display the Fahrenheit array values.
      Console.WriteLine("Temperature in Fahrenheit: ");
    foreach (double f in Fahrenheit) {
  Console.WriteLine(f);
}
      //Calculate the sum of the fahrenheit array
      //Use the sum to calculate the average average temperature in fahrenheit.
double avg = Fahrenheit.Sum() / 7;
  Console.WriteLine("Average weekly temperature is = " + avg + " degrees Fahrenheit");
    }
  }