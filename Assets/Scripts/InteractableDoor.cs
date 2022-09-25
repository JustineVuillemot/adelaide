using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableDoor : Interactable
{
    public Inventory inventory;
    public InteractableCollectable neededToWin;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        MusicSystem.M_Defeat.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        MusicSystem.M_Victory.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {

        MusicSystem.M_Phase1.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);

        if (inventory.HasCollectableInInventory(neededToWin))
        {
            SceneManager.LoadScene("EndWin");
            MusicSystem.M_Victory.start();
        }

        else
        {
            SceneManager.LoadScene("EndLoose");
            MusicSystem.M_Defeat.start();
        }
    }
}
