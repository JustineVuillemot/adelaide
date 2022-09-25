using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InteractableDoor : Interactable
{
    public Inventory inventory;
    public InteractableCollectable neededToWin;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {
        // pointer is over UI we don't want to interact with scene objects then
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (inventory.HasCollectableInInventory(neededToWin))
        {
            SceneManager.LoadScene("EndWin");
        }
        else
        {
            SceneManager.LoadScene("EndLoose");
        }
    }
}
