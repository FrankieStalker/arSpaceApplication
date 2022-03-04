using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfo : MonoBehaviour
{
    //Variable for info panel
    public GameObject infoPanel;

    public void ShowInfo()
    {
        //Check for info panel not being null
        if(infoPanel != null)
        {
            //Check to see if info panel is active
            bool isActive = infoPanel.activeSelf;

            //Set info panel active
            infoPanel.SetActive(!isActive);
        }
    }

}
