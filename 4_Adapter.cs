using Newtonsoft.Json;
using System.Collections.Generic;

public class JsonAdapter : IJsonData
{
    //Private instance of service
    private WeatherData weatherData;

    public JsonAdapter(WeatherData weatherData)
    {
        //Assign service object
        this.weatherData = weatherData;
    } //Constructor

    public string GetJson()
    {
        //Create and return formatted Json string
        List<string[]> csv = weatherData.GetData();
        return JsonConvert.SerializeObject(csv, Formatting.Indented);
    } //GetJson
} //class JsonAdapter
