using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using Gley.MobileAds;
public class PlatformManager : MonoBehaviour
{
    // UI elements to interact with
    public GameObject closeMenu;
    public GameObject infoMenu;
    public Button searchButton;
    public Dropdown cityDropdown;  // Dropdown to select the city
    public Text resultText;         // Text to display the result


    public void NoButtonClick()
    {
        closeMenu.SetActive(false);
    }
    public void YesButtonClick()
    {
        Application.Quit();
    }
    public void CloseButtonClick()
    {
        closeMenu.SetActive(true);
    }
    public void InfoButtonClick()
    {
        infoMenu.SetActive(true);
    }
    public void CloseInfoButton()
    {
        infoMenu.SetActive(false);
    }
    public void RateUsButton()
    {
        Application.OpenURL ("market://details?id=" + Application.productName);
    }
      public void YoutubeButton()
    {
        Application.OpenURL ("https://www.youtube.com/watch?v=xKCPGzffd0g");
    }

    // List of KeyValuePair to store platform name (city) and corresponding platform numbers
    List<KeyValuePair<string, string>> platformInfo = new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string, string>("Allagadda", "31"),
        new KeyValuePair<string, string>("Anakapalle", "43"),
        new KeyValuePair<string, string>("Anantapur", "36"),
        new KeyValuePair<string, string>("Anupalli", "43"),
        new KeyValuePair<string, string>("Applayagunta", "64"),
        new KeyValuePair<string, string>("Atmakur", "31"),
        new KeyValuePair<string, string>("Badrachalam", "17"),
        new KeyValuePair<string, string>("Badvel", "34"),
        new KeyValuePair<string, string>("Ballari", "36"),
        new KeyValuePair<string, string>("Banaganapalli", "32"),
        new KeyValuePair<string, string>("Bengaluru", "21,22,23"),
        new KeyValuePair<string, string>("Boyalagadda", "64"),
        new KeyValuePair<string, string>("Chengalpattu", "4"),
        new KeyValuePair<string, string>("Chennai", "1,2,3"),
        new KeyValuePair<string, string>("Chelluru", "58,59"),
        new KeyValuePair<string, string>("Chittoor", "28,58,59"),
        new KeyValuePair<string, string>("Coimbatore", "25,26"),
        new KeyValuePair<string, string>("Collecter Office", "64"),
        new KeyValuePair<string, string>("Dhone", "32"),
        new KeyValuePair<string, string>("Eluru", "14"),
        new KeyValuePair<string, string>("Giddaluru", "32"),
        new KeyValuePair<string, string>("Gudur", "18"),
        new KeyValuePair<string, string>("Gudimallam", "58,59"),
        new KeyValuePair<string, string>("Guntakal", "36"),
        new KeyValuePair<string, string>("Hindupuram", "36"),
        new KeyValuePair<string, string>("Hospet", "36"),
        new KeyValuePair<string, string>("Housur", "29"),
        new KeyValuePair<string, string>("Hyderabad", "30"),
        new KeyValuePair<string, string>("Jammalamadugu", "32"),
        new KeyValuePair<string, string>("Kadapa", "33"),
        new KeyValuePair<string, string>("Kakinada", "14"),
        new KeyValuePair<string, string>("Kalluru", "42"),
        new KeyValuePair<string, string>("Kampalli", "63"),
        new KeyValuePair<string, string>("Kanipakam", "44"),
        new KeyValuePair<string, string>("Kanchipuram", "4,5"),
        new KeyValuePair<string, string>("Karvetinagaram", "61"),
        new KeyValuePair<string, string>("Kavali", "18"),
        new KeyValuePair<string, string>("Koduru", "35"),
        new KeyValuePair<string, string>("Konduru", "35"),
        new KeyValuePair<string, string>("Koyalakuntla", "34"),
        new KeyValuePair<string, string>("Krishnagiri", "29"),
        new KeyValuePair<string, string>("Kuppam", "29"),
        new KeyValuePair<string, string>("Kurnool", "30"),
        new KeyValuePair<string, string>("Macharla", "11,17"),
        new KeyValuePair<string, string>("Machilipatnam", "12"),
        new KeyValuePair<string, string>("Madanapalle", "37,38"),
        new KeyValuePair<string, string>("Madurai", "25,26"),
        new KeyValuePair<string, string>("Mangalampeta", "41"),
        new KeyValuePair<string, string>("Markapuram", "15"),
        new KeyValuePair<string, string>("Mirayalaguda", "17"),
        new KeyValuePair<string, string>("Mulapalli", "42"),
        new KeyValuePair<string, string>("Musalipedu", "58,59"),
        new KeyValuePair<string, string>("Mysore", "24"),
        new KeyValuePair<string, string>("Nagiri", "6"),
        new KeyValuePair<string, string>("Nalgonda", "17"),
        new KeyValuePair<string, string>("Nandyala", "31"),
        new KeyValuePair<string, string>("Narasapur", "14"),
        new KeyValuePair<string, string>("Narsaraopeta", "11"),
        new KeyValuePair<string, string>("Nayanapakala", "42"),
        new KeyValuePair<string, string>("Nellore", "16,17,18"),
        new KeyValuePair<string, string>("Nuziveedu", "12"),
        new KeyValuePair<string, string>("Paidpalle", "63"),
        new KeyValuePair<string, string>("Palamaner", "29"),
        new KeyValuePair<string, string>("Pachikapallam", "61"),
        new KeyValuePair<string, string>("Pakala", "42"),
        new KeyValuePair<string, string>("Pallipattu", "61"),
        new KeyValuePair<string, string>("Penagaluru", "35"),
        new KeyValuePair<string, string>("Penumuru", "61"),
        new KeyValuePair<string, string>("Pileru", "39"),
        new KeyValuePair<string, string>("Pondicherry", "3,5"),
        new KeyValuePair<string, string>("Proddatur", "32"),
        new KeyValuePair<string, string>("Punganur", "42"),
        new KeyValuePair<string, string>("Pulivendula", "34"),
        new KeyValuePair<string, string>("Puttur", "6"),
        new KeyValuePair<string, string>("Ramapuram", "63"),
        new KeyValuePair<string, string>("Rajahmundry", "13"),
        new KeyValuePair<string, string>("Rajampeta", "34,35"),
        new KeyValuePair<string, string>("Rapur", "20"),
        new KeyValuePair<string, string>("Rayachoty", "41"),
        new KeyValuePair<string, string>("Rayadurgam", "36"),
        new KeyValuePair<string, string>("S Gollapalli", "40"),
        new KeyValuePair<string, string>("Saraswathi Kandriga", "58,59"),
        new KeyValuePair<string, string>("Sathyavedu", "7"),
        new KeyValuePair<string, string>("Satenapalli", "11,17"),
        new KeyValuePair<string, string>("Selam", "25,26"),
        new KeyValuePair<string, string>("Srisailam", "15,34"),
        new KeyValuePair<string, string>("Sriharikota", "19"),
        new KeyValuePair<string, string>("SriKalahasti", "8,9,10"),
        new KeyValuePair<string, string>("Sulurupeta", "19"),
        new KeyValuePair<string, string>("Sundupalli", "40"),
        new KeyValuePair<string, string>("Tadipatri", "34"),
        new KeyValuePair<string, string>("Tanuku", "14"),
        new KeyValuePair<string, string>("Tanjavur", "26,26"),
        new KeyValuePair<string, string>("Thalakona", "40"),
        new KeyValuePair<string, string>("Thadalam", "64"),
        new KeyValuePair<string, string>("Tirumala", "45,46,47,48,49,50,51,52,53,54,55,56"),
        new KeyValuePair<string, string>("Tiruttani", "5"),
        new KeyValuePair<string, string>("Tiruvannamali", "27"),
        new KeyValuePair<string, string>("Tirichy", "25,26"),
        new KeyValuePair<string, string>("Vakadu", "18"),
        new KeyValuePair<string, string>("Vellore", "27"),
        new KeyValuePair<string, string>("Vijaywada", "13"),
        new KeyValuePair<string, string>("Venkatagiri", "20"),
        new KeyValuePair<string, string>("Vinukonda", "12"),
        new KeyValuePair<string, string>("Visakhpatnam", "13"),
    };


    void Start()
    {
        closeMenu.SetActive(false);
        infoMenu.SetActive(false);
        // Populate the dropdown with city names
        PopulateCityDropdown();

        // Attach the button click event
        searchButton.onClick.AddListener(OnSearchButtonClick);
    }

    // Populate the dropdown with city names
    void PopulateCityDropdown()
    {
        List<string> cityNames = new List<string>();

        // Add "Select City" as the default first option
        cityNames.Add("Select City");

        // Add the platform cities to the dropdown
        foreach (var platform in platformInfo)
        {
            cityNames.Add(platform.Key);  // Add the city names to the dropdown options
        }

        // Clear any existing options and add the new ones
        cityDropdown.ClearOptions();
        cityDropdown.AddOptions(cityNames);
    }

    // Method called when the search button is clicked
    void OnSearchButtonClick()
    {
        resultText.text = "";
        // Get the selected city from the dropdown
        string selectedCity = cityDropdown.options[cityDropdown.value].text;

        // Check if a valid city was selected (i.e., not "Select City")
        if (selectedCity == "Select City")
        {
            resultText.text = "Please select a valid city.";
        }
        else
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                API.ShowInterstitial();
            }
            // Get platform numbers based on city name
            List<int> platformNumbers = GetPlatformNumbersByCity(selectedCity);

            // Display the result in the Text UI element
            if (platformNumbers.Count > 0)
            {
                //resultText.text = "Platform numbers for " + selectedCity + ": " + string.Join(", ", platformNumbers);
                CommonItems.selectedCity = selectedCity;
                CommonItems.selectedPlatform = string.Join(", ", platformNumbers);
                PlayerPrefs.SetString("level","MS");
                SceneManager.LoadScene("LoadingScreen");
            }
            else
            {
                resultText.text = "City not found: " + selectedCity;
            }
        }
    }

    // Method to search for platform numbers based on city name
    List<int> GetPlatformNumbersByCity(string cityName)
    {
        // Initialize an empty list to hold the platform numbers
        List<int> platformNumbers = new List<int>();

        // Loop through the KeyValuePair list to find the city name
        foreach (var platform in platformInfo)
        {
            if (platform.Key.Equals(cityName, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
            {
                // Split the platform numbers (value) by commas
                string[] numbersArray = platform.Value.Split(',');

                foreach (var number in numbersArray)
                {
                    if (int.TryParse(number.Trim(), out int platformNumber))
                    {
                        platformNumbers.Add(platformNumber);
                    }
                }

                // Return the list of platform numbers
                return platformNumbers;
            }
        }

        // If no city was found, return an empty list
        return platformNumbers;
    }
}














