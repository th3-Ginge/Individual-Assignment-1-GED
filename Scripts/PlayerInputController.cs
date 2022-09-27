using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public PlayerAction inputAction;

    private void OnEnable()
    {
        inputAction.Enable();
    
    
        
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }
    // Start is called before the first frame update

   /* void Awake()
    {
        if (controller == null)
        {

        }
    }*/


}
