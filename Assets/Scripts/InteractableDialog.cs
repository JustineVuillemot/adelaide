using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDialog : Interactable
{
    public Inventory inventory;
    public InteractableCollectable toGiveInInventory;

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
        gameObject.SetActive(false);

        // Launch dialog

        inventory.AddObjectToInventory(toGiveInInventory);

        // SOUND
        // Here is the sound for when an object is collected and placed in the inventory
        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/SD_HarvestItem");
    }
}
