using System;
using System.Collections.Generic;

class Client
{
    static void Main(string[] args)
    {
        //Black on white
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        //Instantiate original weather data object
        string fileName = "WeatherHistory.csv";
        WeatherData weatherData = new WeatherData(fileName);

        //Print data from original object
        Console.WriteLine("\tOriginal data");
        Console.WriteLine("\t=============");
        List<string[]> data = weatherData.GetData();
        foreach (string[] line in data)
        {
            foreach (string field in line)
                Console.Write(field.PadLeft(20, ' '));
            Console.WriteLine();
        }

        //Instantiate adapter
        JsonAdapter adapter = new JsonAdapter(weatherData);

        //Get json string and display in Json format
        Console.WriteLine();
        Console.WriteLine("\tJSON format");
        Console.WriteLine("\t===========");
        string json = adapter.GetJson();
        Console.WriteLine(json);

        //Wait for user
        Console.ReadKey();

    } //Main

} //class Client

