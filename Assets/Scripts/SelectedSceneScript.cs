using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectedSceneScript : MonoBehaviour
{
    public Text selectedCityTxt;
    public Text selectedPlatformTxt;
    void Start()
    {
        selectedCityTxt.text = "Tirupati to "+CommonItems.selectedCity;
        selectedPlatformTxt.text = CommonItems.selectedPlatform;
    }
    public void BackButton()
    {
        PlayerPrefs.SetString("level","SM");
        SceneManager.LoadScene("LoadingScreen");
    }
    public void ShowTimeMenu()
    {
        PlayerPrefs.SetString("level","ST");
        SceneManager.LoadScene("LoadingScreen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
