using System.Collections.Generic;
using System.IO;

public class WeatherData
{
    private string fileName;

    public WeatherData(string fileName)
    {
        this.fileName = fileName;
    }

    public List<string[]> GetData()
    {
        string[] lines = File.ReadAllLines(fileName);

        List<string[]> csv = new List<string[]>();
        foreach (string line in lines)
            csv.Add(line.Split(','));
        return csv;
    }
} //class WeatherData
