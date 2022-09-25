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
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {
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
