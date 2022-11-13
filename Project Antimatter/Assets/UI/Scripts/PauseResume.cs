using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    [SerializeField] GameObject QuitDialogueScreen;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject ResumeButton;
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject ButtonGroup1;
    [SerializeField] GameObject ButtonGroup2;
    [SerializeField] GameObject filter;
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !PauseScreen.activeSelf)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && PauseScreen.activeSelf)
        {
            Resume();
        }
    }
    public void Pause()
    {
        PauseButton.SetActive(false);
        ResumeButton.SetActive(true);
        filter.SetActive(true);
        PauseScreen.SetActive(true);
        ButtonGroup1.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        ResumeButton.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
        ButtonGroup1.SetActive(false);
        filter.SetActive(false);

    }

    public void QuitDialogue()
    {
        ButtonGroup1.SetActive(false);
        QuitDialogueScreen.SetActive(true);
        ButtonGroup2.SetActive(true);

    }

    public void CancelQuitDialogue()
    {
        QuitDialogueScreen.SetActive(false);
        ButtonGroup1.SetActive(true);
    }
}
