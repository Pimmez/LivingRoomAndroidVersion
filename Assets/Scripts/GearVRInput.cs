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
            //On Swipe down wordt de volgend code goed uitgevoerd, maar omdat in de swipe ook een touchTap zit (aan het begin), wordt de movement functie aangeroepen.
            ChangeRenderMaterial[] renders = FindObjectsOfType(typeof(ChangeRenderMaterial)) as ChangeRenderMaterial[];
            foreach (ChangeRenderMaterial render in renders)
            {
                if (render.playerFund == true)
                {
                    render.ChangeRenderWallpaper();
                }
            }
            if (lights.playerFound == true)
            {
                lights.LightingSwitch();
            }
            //Debug.Log("Tap");
        }
        if (touchArgs.TouchType == OVRTouchpad.TouchEvent.Down) //Geeft True Terug
        {
            charMove.letsMove = false; 
            //Debug.Log("Down");

        }
    }

}
