using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public float loadTime = 5f;
    [SerializeField] Animator logoAnim;
    void Start()
    {
        logoAnim.Play("LogoAnim");
    }

    // Update is called once per frame
    void Update()
    {
        loadTime -= Time.deltaTime;

        if (loadTime <= 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
