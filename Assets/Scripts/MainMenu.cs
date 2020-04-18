using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSite()
    {
        SceneManager.LoadScene("Augmented Image");
    }

    public void OffSite()
    {
        SceneManager.LoadScene("Not Site");
    }

    public void gotoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
