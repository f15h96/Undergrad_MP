using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugmentedImageStart : MonoBehaviour
{
    public StartPhase startPhase;
    public Canvas canvas;
    public Pose visualizerPose;

    public GameObject phase;
    // Start is called before the first frame update
    void Start()
    {
        enableCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /**
     * enables the canvas objects so that they are visable for the user
     */
    public void enableCanvas()
    {
        canvas.gameObject.SetActive(true);
        startPhase.enabled = true;
        startPhase.currentPhase = phase;
        startPhase.currentPhasePose = visualizerPose;
    }
}
