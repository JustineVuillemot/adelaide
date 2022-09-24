using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        inventory.AddObjectToInventory(this);
        gameObject.SetActive(false);

        // SOUND
        // Here is the sound for when an object is collected and placed in the inventory
    }
}
