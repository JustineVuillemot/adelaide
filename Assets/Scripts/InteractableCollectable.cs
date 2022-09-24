using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCollectable : Interactable
{
    public Inventory inventory;

    private SpriteRenderer collectableVisual;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        collectableVisual = GetComponent<SpriteRenderer>();

        if (collectableVisual == null)
        {
            Debug.LogError("Collectable must have a sprite attached to the same game object.");
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {
        inventory.AddObjectToInventory(collectableVisual);
        gameObject.SetActive(false);
    }
}
