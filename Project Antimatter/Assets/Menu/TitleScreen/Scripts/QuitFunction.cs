using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitFunction : MonoBehaviour
{
    [SerializeField] GameObject QuitDialogue;
    [SerializeField] GameObject ButtonGroup1;
    [SerializeField] GameObject ButtonGroup2;
    [SerializeField] GameObject filter;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !QuitDialogue.activeSelf)
        {
            QuitDialogueScreen();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && QuitDialogue.activeSelf)
        {
            CancelQuitDialogueScreen();
        }
    }
    public void QuitDialogueScreen()
    {
        filter.SetActive(true);
        ButtonGroup1.SetActive(false);
        QuitDialogue.SetActive(true);
        ButtonGroup2.SetActive(true);
    }
    public void CancelQuitDialogueScreen()
    {
        ButtonGroup2.SetActive(false);
        QuitDialogue.SetActive(false);
        ButtonGroup1.SetActive(true);
        filter.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
