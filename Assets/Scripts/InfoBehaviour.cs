using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    const float SPEED = 6f;

    [SerializeField]
    Transform SectionInfo; //What we are scaling

    //Setting the desired scale
    Vector3 desiredScale = Vector3.zero; //What we are going to intepolate too, We want it to default to the info being off

    // Update is called once per frame
    void Update()
    {
        //Interpolating SectionInfo
        //Moving SectionInfo.localScale to desiredScale by doing Time.deltaTime * SPEED
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    //Opening the Info
    public void OpenInfo()
    {
        desiredScale = Vector3.one;
    }

    //Closing the Info
    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }
}
