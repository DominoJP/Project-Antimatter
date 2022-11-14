using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public float loadTime = 3f;

    void Update()
    {
        loadTime -= Time.deltaTime;

        if (loadTime <= 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
