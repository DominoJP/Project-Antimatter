using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    bool isApplicableScene = false;
    public void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "ControlsScene")
        {
            isApplicableScene = true;
        }
        else if (sceneName == "CreditsScene")
        {
            isApplicableScene = true;
        }
    }
    public void SceneChange (string sceneValue)
    {
        SceneManager.LoadScene(sceneValue);
    }
    public void Update()
    {
        if (isApplicableScene && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }

    }
}
