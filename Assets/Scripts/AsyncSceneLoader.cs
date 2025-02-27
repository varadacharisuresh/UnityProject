/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.
Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using Gley.MobileAds;
public class AsyncSceneLoader : MonoBehaviour
{
    public float loadingDelay = 5.0F;
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            API.Initialize();
        }
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        StartCoroutine(LoadNextSceneAfter(loadingDelay));
    }

    private void Awake()
    {

    }
    private IEnumerator LoadNextSceneAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
