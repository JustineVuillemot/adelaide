using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableLocked : Interactable
{
    public GameObject lockedSprite;
    public GameObject unlockedSprite;
    public InteractableCollectable unlockingCollectable;

    private Collider2D collider;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        // Be sure the base sprite is the only one displayed
        lockedSprite.SetActive(true);
        unlockedSprite.SetActive(false);

        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    public void Unlock()
    {
        lockedSprite.SetActive(false);
        unlockedSprite.SetActive(true);
        focusedSprite.SetActive(false);

        // SOUND
        // Here sound for unlocking the object (opening the cupboard) 


        if (collider != null)
        {
            collider.enabled = false;
        }
    }
    protected override void OnMouseDown()
    {
        //Debug.Log("Mouse just clicked : " + gameObject.name);

        // SOUND
        // Here play sound that says the object is locked (can't be interacted with)
        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/SD_Locked");
    }
}
