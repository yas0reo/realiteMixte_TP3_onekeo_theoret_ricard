using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlMenu : MonoBehaviour
{
    public InputActionProperty boutonMenu;
    public GameObject canvaMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(boutonMenu.action.WasPressedThisFrame())
        {
            canvaMenu.SetActive(true);
        }
    }
}
