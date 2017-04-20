using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement1 : MonoBehaviour {

    public float maxVelocity = 5.0F;
    public float acceleration = 0.15F;

    public bool letsMove;
    private Transform cameraTransform;
    private CharacterController controller;
    private float currentVelocity = 0.0F;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        ForwardMovement();
    }

    void ForwardMovement()
    {
        Vector3 forward = transform.TransformDirection(cameraTransform.forward);
        
        if (Input.GetAxis("Mouse Y") < -0.5)
        {
            letsMove = true;
            
            /*
           /Debug.Log("Mouse Y: " + Input.GetAxis("Mouse Y"));
            currentVelocity += acceleration;
            currentVelocity++;
            currentVelocity += Mathf.Clamp(currentVelocity, 0.0F, maxVelocity);
            */
        }
        if(letsMove == true)
        {
            controller.SimpleMove(forward * 2);
        }

        if (Input.GetAxis("Mouse Y") == 0)
        {
            currentVelocity = 0.0F;
        }
    }

}
