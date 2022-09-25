using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableCollectable : Interactable
{
    public Inventory inventory;
    public Sprite collectableInventoryVisual;
    public Sprite collectableInventoryFocused;

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

        inventory.AddObjectToInventory(this);
        gameObject.SetActive(false);

        // SOUND
        // Here is the sound for when an object is collected and placed in the inventory
        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/SD_HarvestItem");
    }
}
