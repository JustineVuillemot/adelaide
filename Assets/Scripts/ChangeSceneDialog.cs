using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneDialog : SimpleDialog
{
    public string sceneName;

    protected override void EndDialog()
    {
        SceneManager.LoadScene(sceneName);
    }
}
