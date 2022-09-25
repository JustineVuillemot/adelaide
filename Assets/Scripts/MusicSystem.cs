using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSystem : MonoBehaviour
{
    public static FMOD.Studio.EventInstance M_Victory;
    public static FMOD.Studio.EventInstance M_Defeat;
    public static FMOD.Studio.EventInstance M_Phase1;


    // Start is called before the first frame update
    void Start()
    {
        M_Victory = FMODUnity.RuntimeManager.CreateInstance("event:/Music/M_Victory");
        M_Defeat = FMODUnity.RuntimeManager.CreateInstance("event:/Music/M_Defeat");
        M_Phase1 = FMODUnity.RuntimeManager.CreateInstance("event:/Music/M_Phase1");
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void StopDefeat()
    {
        M_Defeat.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }

    public static void StopVictory()
    {
        M_Victory.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
