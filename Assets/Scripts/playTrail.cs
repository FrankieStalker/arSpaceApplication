using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTrail : MonoBehaviour
{
    public ParticleSystem trail;

    bool particlActive = false;

    public void playParticleTrail()
    {
        if (particlActive == false)
        {
            particlActive = true;
        }
        else
        {
            particlActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(particlActive == true)
        {
            trail.Play();
        }
        else
        {
            trail.Pause();
        }
    }
}
