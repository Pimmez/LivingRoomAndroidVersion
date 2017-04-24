using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearVRInput : MonoBehaviour {

    private LightsOut lights;
    private ChangeRenderMaterial[] renders;
    private CharacterMovement1 charMove;

    void Start()
    {
        OVRTouchpad.Create();
        OVRTouchpad.TouchHandler += HandleTouchHandler;
        lights = FindObjectOfType<LightsOut>();
        charMove = GetComponent<CharacterMovement1>();
    }

    void HandleTouchHandler(object sender, System.EventArgs e)
    {

        OVRTouchpad.TouchArgs touchArgs = (OVRTouchpad.TouchArgs)e;
        if (touchArgs.TouchType == OVRTouchpad.TouchEvent.SingleTap)
        {
            ChangeRenderMaterial[] renders = FindObjectsOfType(typeof(ChangeRenderMaterial)) as ChangeRenderMaterial[];
            foreach (ChangeRenderMaterial render in renders)
            {
                if (render.playerFound == true)
                {
                    render.ChangeRenderWallpaper();
                }
            }
            if (lights.playerFound == true)
            {
                lights.LightingSwitch();
            }
        }
        if (touchArgs.TouchType == OVRTouchpad.TouchEvent.Down)
        {
            charMove.letsMove = false; 

        }
    }

}
