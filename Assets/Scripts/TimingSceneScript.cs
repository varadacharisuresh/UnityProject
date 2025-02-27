using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimingSceneScript : MonoBehaviour
{
    public Text selectedCityTxt;
    public Text selectedTimingsTxt;

    void Start()
    {
        selectedCityTxt.text = "Tirupati to " + CommonItems.selectedCity;
        // Get platform numbers based on city name
        List<string> timingsList = GetTimingByCity(CommonItems.selectedCity);
        CommonItems.selectedTimings = string.Join(", ", timingsList);
        selectedTimingsTxt.text = CommonItems.selectedTimings;
    }
    public void BackButton()
    {
        PlayerPrefs.SetString("level", "MS");
        SceneManager.LoadScene("LoadingScreen");
    }
    public void BackHomeButton()
    {
        PlayerPrefs.SetString("level", "SM");
        SceneManager.LoadScene("LoadingScreen");
    }
    // Update is called once per frame
    void Update()
    {

    }
    List<KeyValuePair<string, string>> TimingsInfo = new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string, string>("Allagadda", "5.30,6.30")
    };
    List<string> GetTimingByCity(string cityName)
    {
        // Initialize an empty list to hold the platform numbers
        List<string> timings = new List<string>();

        // Loop through the KeyValuePair list to find the city name
        foreach (var timingInfo in TimingsInfo)
        {
            if (timingInfo.Key.Equals(cityName, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
            {
                // Split the platform numbers (value) by commas
                string[] timingsArray = timingInfo.Value.Split(',');

                foreach (var timingsVal in timingsArray)
                {
                    timings.Add(timingsVal);
                }

                // Return the list of platform numbers
                return timings;
            }
        }

        // If no city was found, return an empty list
        return timings;
    }
}