using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableLocked : Interactable
{
    public GameObject lockedSprite;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        // Be sure the base sprite is the only one displayed
        lockedSprite.SetActive(true);
    }

    // Update is called once per frame
    protected override void Update()
    {
    }
    protected override void OnMouseDown()
    {
        //Debug.Log("Mouse just clicked : " + gameObject.name);
        
        // SOUND
        // Here play sound that says the object is locked (can't be interacted with)
    }
}
