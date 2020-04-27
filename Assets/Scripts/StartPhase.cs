using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using GoogleARCore;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class StartPhase : MonoBehaviour
{
    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    public GameObject phase4;
    public Slider slider;
    public GameObject currentPhase;
    public Pose currentPhasePose;
    public Button button;
    private Anchor anchor;
    public Canvas canvas;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
    }

    /**
     * initiates the starting phase when the start button is pressed
     */
    public void startPhase1()
    {
        currentPhase = Instantiate(phase1, transform.right, this.transform.rotation);
        if (button != null)
        {
            button.gameObject.active = false;
        }
        
    }

    /**
     * changes the models that is displayed and anchors the model to a specific position in the world
     */
    public void changeModel()
    {
        switch (slider.value)
        {
            case 0:
                Destroy(currentPhase);
                currentPhase = Instantiate(phase1, currentPhasePose.position, currentPhasePose.rotation);

                break;
            case 1:
                Destroy(currentPhase);
                currentPhase = Instantiate(phase2, currentPhasePose.position, currentPhasePose.rotation);
                break;
            case 2:
                Destroy(currentPhase);
                currentPhase = Instantiate(phase3, currentPhasePose.position, currentPhasePose.rotation);
                break;
            case 3:
                Destroy(currentPhase);
                currentPhase = Instantiate(phase4, currentPhasePose.position, currentPhasePose.rotation);
                break;
            default:
                print("Didnt go into any of the cases");
                break;


        }
        currentPhasePose.position = currentPhase.transform.position;
        currentPhasePose.rotation = currentPhase.transform.rotation;
        anchor = Session.CreateAnchor(currentPhasePose);
        UnityEngine.Debug.Log(anchor.transform.position);
        currentPhase.transform.parent = anchor.transform;
    }
}
