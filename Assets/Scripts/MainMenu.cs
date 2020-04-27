using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Canvas canvas;
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

        canvas.transform.Find("OnSite").gameObject.SetActive(false);
        canvas.transform.Find("OffSite").gameObject.SetActive(false);
        canvas.transform.Find("LoadingText").gameObject.SetActive(true);
        SceneManager.LoadScene("Augmented Image");
    }

    public void OffSite()
    {
        canvas.transform.Find("OnSite").gameObject.SetActive(false);
        canvas.transform.Find("OffSite").gameObject.SetActive(false);
        canvas.transform.Find("LoadingText").gameObject.SetActive(true);
        SceneManager.LoadScene("Not Site");
    }

    public void gotoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
