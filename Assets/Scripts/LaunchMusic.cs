using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MusicSystem.M_Defeat.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        MusicSystem.M_Victory.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        MusicSystem.M_Phase1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        MusicSystem.M_Phase1.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
