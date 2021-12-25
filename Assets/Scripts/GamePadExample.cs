using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePadExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamepad.current.buttonNorth.wasPressedThisFrame)
        {
            Debug.Log("Button Northが押された!");
        }
        if(Gamepad.current.buttonSouth.wasReleasedThisFrame){
            Debug.Log("Button Southが話された!");
        }
    }

    void OnGUI() {
        {
            if(Gamepad.current==null) return;

            GUILayout.Label($"leftStick: {Gamepad.current.leftStick.ReadValue()}");
            GUILayout.Label($"buttonNorth: {Gamepad.current.buttonNorth.isPressed}");
            GUILayout.Label($"buttonSouth: {Gamepad.current.buttonSouth.isPressed}");
            GUILayout.Label($"buttonEast: {Gamepad.current.buttonEast.isPressed}");
            GUILayout.Label($"buttonWest: {Gamepad.current.buttonWest.isPressed}");
            GUILayout.Label($"leftShoulder: {Gamepad.current.leftShoulder.ReadValue()}");
            GUILayout.Label($"leftTrigger: {Gamepad.current.leftTrigger.ReadValue()}");
            GUILayout.Label($"rightShoulder: {Gamepad.current.rightShoulder.ReadValue()}");
            GUILayout.Label($"rightTrigger: {Gamepad.current.rightTrigger.ReadValue()}");
        }
    }
}
