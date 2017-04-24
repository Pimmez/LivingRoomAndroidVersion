using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour {

    [SerializeField] private Light[] lights;
    private bool isClicked;
    public bool playerFound; //Public because GearVRInput needs to acces it 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = false;
        }
    }

    public void LightingSwitch()
    {
        isClicked = !isClicked;

        if (isClicked)
        {
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
        }
        else if (!isClicked)
        {
            foreach (Light light in lights)
            {
                light.enabled = true;
            }

        }
    }

}
