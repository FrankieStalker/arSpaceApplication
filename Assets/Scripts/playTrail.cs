using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTrail : MonoBehaviour
{
    //Variable for particle system
    public ParticleSystem trail;

    bool particlActive = false;

    public void playParticleTrail()
    {
        //When button is pressed make true if false
        if (particlActive == false)
        {
            particlActive = true;
        }
        else //If true make false
        {
            particlActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //If true play the particle trail
        if(particlActive == true)
        {
            trail.Play();
        }
        else //If !true pause particle trail
        {
            trail.Pause();
        }
    }
}
