using System.Collections.Generic; //For List<>
using System.Linq; //For To.List()
using UnityEngine;

//Need to loop through all the behaviours we have and turn them on and off
public class GazeInteraction : MonoBehaviour
{
    List<InfoBehaviour> infos = new List<InfoBehaviour>();
    // Start is called before the first frame update
    void Start()
    {
        //Find objects of type once on start for efficency //.ToList() puts everything into a list
        infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        //Origin is the position of main camera
        //Want to do raycast on the forward vector of the camera
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            //Checks the objects that is hit
            GameObject go = hit.collider.gameObject;
            if(go.CompareTag("hasInfo"))
            {
                OpenInfo(go.GetComponent<InfoBehaviour>());
            }
        }
        else
        {
            CloseAll();
        }
    }
    
    void OpenInfo(InfoBehaviour desiredInfo)
    {
        //Looping through all InfoBehaviours we have
        foreach(InfoBehaviour info in infos)
        {
            //Turn off all info but keep the desired one
            if(info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }
    void CloseAll()
    {
        //Looping through all InfoBehaviours we have
        foreach (InfoBehaviour info in infos)
        {
            info.CloseInfo();
        }
    }
}
