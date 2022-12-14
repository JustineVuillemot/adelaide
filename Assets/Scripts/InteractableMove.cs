using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableMove : Interactable
{
    public GameObject baseSprite;
    public GameObject clickedSprite;

    private Collider2D collider;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        // Be sure the base sprite is the only one displayed
        baseSprite.SetActive(true);
        clickedSprite.SetActive(false);

        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    protected override void Update()
    {
    }

    protected override void OnMouseDown()
    {
        // pointer is over UI we don't want to interact with scene objects then
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        //Debug.Log("Mouse just clicked : " + gameObject.name);
        baseSprite.SetActive(false);
        clickedSprite.SetActive(true);

        // SOUND
        // Here sound for the cussion moving on the chair
        FMODUnity.RuntimeManager.PlayOneShot("event:/SD/SD_Pillow");

        if (collider != null)
        {
            collider.enabled = false;
        }
    }
}
