using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject homePage;

    public void Update()
    {
        if(titleScreen == true || homePage == true)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }
    }
    public void titleScreenProceed()
    {
        homePage.SetActive(true);
        titleScreen.SetActive(false);
    }

    public void backToTitle()
    {
        homePage.SetActive(false);
        titleScreen.SetActive(true);
    }

    public void LoadLevel(string newLevel)
    {
        //When level load is clicked load selected level
        //When level load is clicked make screen in landscape mode
        Screen.orientation = ScreenOrientation.Landscape;
        SceneManager.LoadScene(newLevel);
    }

    public void back(string back)
    {
        //When back is clicked load home UI scene
        //When back is clicked make screen in portrait mode
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(back);
    }
}
