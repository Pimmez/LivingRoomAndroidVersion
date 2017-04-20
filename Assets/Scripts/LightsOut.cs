using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour {

    [SerializeField] private Light[] lights;
    private bool isClicked;
    public bool playerFound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = true;
            //isClicked = true;
            //Debug.Log("Player is true");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = false;
            //Debug.Log("Player is false");
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
