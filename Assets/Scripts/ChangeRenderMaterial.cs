using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRenderMaterial : MonoBehaviour{

    [SerializeField] private Material[] materials;
    [SerializeField] private Renderer[] rends;
    private int counter;
    private bool isClicked;
    public bool playerFound; //Public because GearVRInput needs to acces it 

    void Start()
    {
        counter = 0; //Starts Counter at zero
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFound = false;
        }
    }


    public void ChangeRenderWallpaper()
    {
        isClicked = true;
        if (isClicked)
        {
            if (counter < materials.Length - 1) //As long as the counter.length is smaller then the total of materials in the array, counter++
            {
                counter++;
            }
            else //otherwise set the counter to zero
            {
                counter = 0;
            }

            foreach (Renderer rend in rends)
            {
                rend.sharedMaterial = materials[counter]; //Change the render material for every rendered object in the list
            }
        }
        else
        {
            isClicked = false;
        }
    }




}
