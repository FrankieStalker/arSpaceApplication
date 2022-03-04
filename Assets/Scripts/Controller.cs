using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    //Variables to home scene selection and title screen
    public GameObject titleScreen;
    public GameObject homePage;

    public void Update()
    {
        //If both the title screen or home page are true have the screen portriate
        if(titleScreen == true || homePage == true)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else //If entering an AR scene rotate screen landscape
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }
    }

    //When 'touch to start' set scene selection active and title screen !active
    public void titleScreenProceed()
    {
        homePage.SetActive(true);
        titleScreen.SetActive(false);
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
