using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCell : MonoBehaviour
{
    public Inventory inventory;
    public Image focusedSprite;
    public Image cellObject;

    // Start is called before the first frame update
    void Start()
    {
        // Hide sprites in case not already the case
        // Cell should be empty at the beginning
        focusedSprite.gameObject.SetActive(false);
        cellObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseEnter()
    {
        //Debug.Log("Mouse is over : " + gameObject.name);
        focusedSprite.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        //Debug.Log("Mouse just left : " + gameObject.name);
        focusedSprite.gameObject.SetActive(false);
    }
    public void OnMouseDown()
    {
        //Debug.Log("Element clicked : " + gameObject.name);
        inventory.SelectObject(transform.GetSiblingIndex());
    }

    public void OnMouseUp()
    {
        //Debug.Log("Element stop clicked : " + gameObject.name);
        inventory.UnselectCurrentObject();
    }
}
