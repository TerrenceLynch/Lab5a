using System;

class MainClass {
  public static void Main (string[] args) {
    double total = 0;
    
    for(int counter = 1; counter < 8; counter++)
    {
    Console.WriteLine ("What is the distance, in miles covered by Car#" + counter  );
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is the time, in hours take by Car#" + counter);
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = distance/time;
    Console.WriteLine("The speed of Car#" + counter + " is " + speed + " Miles per hour.");
    total = total + speed;
    }
    double average = total/7;
    Console.WriteLine("The average speed is " + average + " mph.");
  }
}