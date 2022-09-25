using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        // pointer is over UI we don't want to interact with scene objects then
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        //Debug.Log("Mouse is over : " + gameObject.name);
        focusedSprite.SetActive(true);
    }

    protected virtual void OnMouseExit()
    {
        // pointer is over UI we don't want to interact with scene objects then
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        //Debug.Log("Mouse just left : " + gameObject.name);
        focusedSprite.SetActive(false);
    }

    protected virtual void OnMouseDown()
    {
        // pointer is over UI we don't want to interact with scene objects then
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Debug.Log("Mouse just clicked : " + gameObject.name);
    }
}
