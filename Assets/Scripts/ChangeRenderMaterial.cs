using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRenderMaterial : MonoBehaviour{

    [SerializeField] private Material[] materials;
    [SerializeField] private Renderer[] rends;
    private int counter;
    private bool isClicked;
    public bool playerFund;

    void Start()
    {
        counter = 0; //Starts Counter at zero
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFund = true;
            //Debug.Log("Player Found");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerFund = false;
            //Debug.Log("Player not Found");
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
