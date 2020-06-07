using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public GameObject camera;
    public Toggle skyboxToggle;
    public Toggle musicToggle;

    public AudioSource backgroundMusic;

    /**
     * enables and disables the skybox
     */
    public void ToggleSkybox()
    {
        if (skyboxToggle.isOn)
        {
            camera.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
        }
        else
        {
            camera.GetComponent<Camera>().clearFlags = CameraClearFlags.Color;
        }
    }

    /**
     * enables and disables the background music
     */
    public void ToggleBackgroundMusic()
    {
        if (musicToggle.isOn)
        {
            backgroundMusic.mute = false;
            if(backgroundMusic.isPlaying == false)
            {
                backgroundMusic.Play();
            }
        }
        else
        {
            backgroundMusic.mute = true;
        }
    }
}
