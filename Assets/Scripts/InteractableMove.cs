using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableMove : Interactable
{
    public GameObject baseSprite;
    public GameObject clickedSprite;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        // Be sure the base sprite is the only one displayed
        baseSprite.SetActive(true);
        clickedSprite.SetActive(false);
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {
        //Debug.Log("Mouse just clicked : " + gameObject.name);
        if (baseSprite.activeSelf)
        {
            baseSprite.SetActive(false);
            clickedSprite.SetActive(true);
        }
        else
        {
            baseSprite.SetActive(true);
            clickedSprite.SetActive(false);
        }
    }
}