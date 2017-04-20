using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPS4 : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("PS4_X"))
        {
            Debug.Log(Input.GetButtonDown("PS4_X") + " ik klik de x button");
        }
        if (Input.GetButtonDown("PS4_O"))
        {
            Debug.Log(Input.GetButtonDown("PS4_O") + " ik klik de O button");
        }
        if (Input.GetButtonDown("PS4_Triangle"))
        {
            Debug.Log(Input.GetButtonDown("PS4_Triangle") + " ik klik de Driehoek button");
        }
        if (Input.GetButtonDown("PS4_Square"))
        {
            Debug.Log(Input.GetButtonDown("PS4_Square") + " ik klik het vierkant button");
        }
        if (Input.GetButtonDown("PS4_Options"))
        {
            Debug.Log(Input.GetButtonDown("PS4_Options") + " ik klik de option button");
        }
        if (Input.GetButtonDown("PS4_Share"))
        {
            Debug.Log(Input.GetButtonDown("PS4_Share") + " ik klik de share button");
        }
        if (Input.GetButtonDown("PS4_L1"))
        {
            Debug.Log(Input.GetButtonDown("PS4_L1") + " ik klik de L1 button");
        }
        if (Input.GetButtonDown("PS4_L3"))
        {
            Debug.Log(Input.GetButtonDown("PS4_L3") + " ik klik de L3 button");
        }
        if (Input.GetButtonDown("PS4_R1"))
        {
            Debug.Log(Input.GetButtonDown("PS4_R1") + " ik klik de R1 button");
        }
        if (Input.GetButtonDown("PS4_R3"))
        {
            Debug.Log(Input.GetButtonDown("PS4_R3") + " ik klik de R3 button");
        }
        if (Input.GetButtonDown("PS4_Touch"))
        {
            Debug.Log(Input.GetButtonDown("PS4_Touch") + " ik klik de PS4_Touch button");
        }
        if (Input.GetButtonDown("PS4_PSN"))
        {
            Debug.Log(Input.GetButtonDown("PS4_PSN") + " ik klik de PS4_PSN button");
        }

        if (Input.GetAxis("PS4_DPadVertical") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_DPadVertical") + " ik beweeg de DPadVertical");
        }

        if (Input.GetAxis("PS4_DPadHorizontal") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_DPadHorizontal") + " ik beweeg de DPadHorizontal");
        }

        if (Input.GetAxis("PS4_RightAnalogHorizontal") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_RightAnalogHorizontal") + " ik beweeg de RightAnalogHorizontal");
        }

        if (Input.GetAxis("PS4_RightAnalogVertical") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_RightAnalogVertical") + " ik beweeg de RightAnalogVertical");
        }

        if (Input.GetAxis("PS4_L2") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_L2") + " ik beweeg de PS4_L2");
        }

        if (Input.GetAxis("PS4_R2") != 0)
        {
            Debug.Log(Input.GetAxis("PS4_R2") + " ik beweeg de PS4_R2");
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log(Input.GetAxis("Horizontal") + " ik beweeg de PS4_LHorizontal");
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            Debug.Log(Input.GetAxis("Vertical") + " ik beweeg de PS4_LVertical");
        }




    }
}
