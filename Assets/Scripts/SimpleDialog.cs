using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDialog : MonoBehaviour
{
    public GameObject[] dialogLines;

    private int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gameObject in dialogLines)
        {
            gameObject.SetActive(false);
        }

        if (dialogLines.Length > 0)
        {
            dialogLines[0].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NextLine()
    {
        dialogLines[currentLine].SetActive(false);

        ++currentLine;

        if (dialogLines.Length > currentLine)
        {
            dialogLines[currentLine].SetActive(true);
        }
        else
        {
            EndDialog();
        }
    }

    protected virtual void EndDialog()
    {
        gameObject.SetActive(false);
    }
}
