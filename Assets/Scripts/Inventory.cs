using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public InventoryCell[] InventoryCells;
    public Image dragImage;

    private List<SpriteRenderer> InventoryObjects = new List<SpriteRenderer>();

    private int selectedObject = -1;

    // Start is called before the first frame update
    void Start()
    {
        dragImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddObjectToInventory(SpriteRenderer toAdd)
    {
        InventoryObjects.Add(toAdd);
        UpdateCellVisual(InventoryObjects.Count - 1);
    }

    public void SelectObject(int index)
    {
        if (index >= InventoryCells.Length || index >= InventoryObjects.Count)
        {
            Debug.LogError("Index is not part of InventoryCells or InventoryObjects array !");
            return;
        }

        selectedObject = index;

        // Hide image in inventory
        InventoryCells[index].cellObject.enabled = false;

        // Update drag image
        dragImage.sprite = InventoryObjects[selectedObject].sprite;
        dragImage.color = InventoryObjects[selectedObject].color; // To comment when real sprite are intagrated
        dragImage.gameObject.SetActive(true);
    }

    public void UnselectCurrentObject()
    {
        if (selectedObject == -1)
        {
            Debug.LogWarning("UnselectCurrentObject called but no object was selected.");
            return;
        }

        dragImage.gameObject.SetActive(false);

        // Hide image in inventory
        InventoryCells[selectedObject].cellObject.enabled = true;

        selectedObject = -1;
    }

    private void UpdateCellVisual(int index)
    {
        if (index >= InventoryCells.Length || index >= InventoryObjects.Count)
        {
            Debug.LogError("index parameter is higher than InventoryCells or InventoryObjects size ! Cell visual can't be updated !");
            return;
        }

        InventoryCells[index].cellObject.sprite = InventoryObjects[index].sprite;
        InventoryCells[index].cellObject.color = InventoryObjects[index].color; // To comment when real sprite are intagrated
    }
}
