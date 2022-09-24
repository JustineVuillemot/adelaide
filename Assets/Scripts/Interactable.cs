using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject focusedSprite;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // Hide focused sprite in case not already the case
        focusedSprite.SetActive(false);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
    }

    protected virtual void OnMouseEnter()
    {
        //Debug.Log("Mouse is over : " + gameObject.name);
        focusedSprite.SetActive(true);
    }

    protected virtual void OnMouseExit()
    {
        //Debug.Log("Mouse just left : " + gameObject.name);
        focusedSprite.SetActive(false);
    }

    protected virtual void OnMouseDown()
    {
        Debug.Log("Mouse just clicked : " + gameObject.name);
    }
}
