using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public InteractableLocked[] lockedObjects;
    public InventoryCell[] InventoryCells;
    public Image dragImage;

    public Vector3 openedPosition;
    public Vector3 closedPosition;

    private List<InteractableCollectable> InventoryObjects = new List<InteractableCollectable>();
    private RectTransform rectTransform; // Need rect transform for anchor position

    private int selectedObject = -1;
    private bool isOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        dragImage.gameObject.SetActive(false);

        isOpened = false;

        rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = closedPosition;
        }

        selectedObject = -1;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddObjectToInventory(InteractableCollectable toAdd)
    {
        InventoryObjects.Add(toAdd);
        UpdateCellVisual(InventoryObjects.Count - 1);

        if (!isOpened)
        {
            ToggleInventory();
        }
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
        InventoryCells[index].cellObject.gameObject.SetActive(false);

        // Update drag image
        dragImage.sprite = InventoryObjects[selectedObject].collectableInventoryVisual;
        dragImage.gameObject.SetActive(true);

        ToggleInventory();
    }

    public void UnselectCurrentObject()
    {
        if (selectedObject == -1)
        {
            Debug.LogWarning("UnselectCurrentObject called but no object was selected.");
            return;
        }

        dragImage.gameObject.SetActive(false);

        foreach (InteractableLocked locked in lockedObjects)
        {
            // not focusing this locked object moving to next one in array
            if (!locked.focusedSprite.activeSelf)
            {
                continue;
            }

            if (locked.unlockingCollectable == InventoryObjects[selectedObject])
            {
                locked.Unlock();
                RemoveFromInventory(selectedObject);
                selectedObject = -1;
                return;
            }
        }

        // Display image in inventory
        InventoryCells[selectedObject].cellObject.gameObject.SetActive(true);
        selectedObject = -1;

        ToggleInventory();
    }

    private void UpdateCellVisual(int index)
    {
        if (index >= InventoryCells.Length || index >= InventoryObjects.Count)
        {
            Debug.LogError("index parameter is higher than InventoryCells or InventoryObjects size ! Cell visual can't be updated !");
            return;
        }

        InventoryCells[index].cellObject.sprite = InventoryObjects[index].collectableInventoryVisual;
        InventoryCells[index].cellObject.gameObject.SetActive(true);
        InventoryCells[index].focusedSprite.sprite = InventoryObjects[index].collectableInventoryFocused;
    }

    private void RemoveFromInventory(int index)
    {
        InventoryObjects.RemoveAt(index);

        for(int i = 0; i < InventoryObjects.Count; ++i)
        {
            UpdateCellVisual(i);
        }
    }

    public void ToggleInventory()
    {
        if (rectTransform == null)
        {
            // can't toggle if rect transform is null
            return;
        }

        if (isOpened)
        {
            rectTransform.anchoredPosition = closedPosition;
        }
        else
        {
            rectTransform.anchoredPosition = openedPosition;
        }

        isOpened = !isOpened;

        // SOUND
        // Here is the sound for the inventory opening or closing
    }
}
