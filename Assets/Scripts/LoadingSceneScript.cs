using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneScript : MonoBehaviour
{

    private RectTransform rectComponent;
    private Image imageComp;
    public float speed = 0.0f;
    public Text loadingText;

    // Use this for initialization
    void Start()
    {
        rectComponent = GetComponent<RectTransform>();
        imageComp = rectComponent.GetComponent<Image>();
        imageComp.fillAmount = 0.0f;
        loadingText.text = "Loading..";
    }

    void Update()
    {
    
            if (imageComp.fillAmount != 1f)
            {
                imageComp.fillAmount = imageComp.fillAmount + Time.deltaTime * speed;
            }
            else
            {
                if (PlayerPrefs.GetString("level").Equals("SM"))
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    SceneManager.LoadScene("MainMenu");
                }
                else if (PlayerPrefs.GetString("level").Equals("MS"))
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    SceneManager.LoadScene("SelectedMenu");    
                }
                else if (PlayerPrefs.GetString("level").Equals("ST"))
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    SceneManager.LoadScene("TimingScene");    
                }
            }
        
    }
}
