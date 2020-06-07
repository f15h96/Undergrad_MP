using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class AugmentedVisualizer : MonoBehaviour
{
    public AugmentedImage Image;
    
    private GameObject controller;

    private AugmentedImageStart imageStart;
    /**
     * enables the Augmented image and changes the position of the models to be overlayed onto the monument
     */
    public void Start()
    {
        GameObject controller = GameObject.Find("ARController");
        controller.GetComponent<AugmentedImageStart>().enabled = true;
        imageStart = controller.GetComponent<AugmentedImageStart>();
        fixLocRot();
    }

    /// <summary>
    /// The Unity Update method.
    /// </summary>
    public void Update()
    {
    }

    /**
     * the adjustment of the phase so that the model is over the monument
     */
    public void fixLocRot()
    {
        Vector3 adjust = new Vector3(0,-0.5f,0.5f);
        this.gameObject.transform.position += adjust;
        Quaternion rot = Quaternion.AngleAxis(0, Vector3.right);
        this.gameObject.transform.rotation = rot;
        imageStart.phase = this.gameObject;
        imageStart.visualizerPose.position = this.transform.position;
        imageStart.visualizerPose.rotation = this.transform.rotation;

    }
        
}
