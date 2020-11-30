using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OnRaycastHit : MonoBehaviour
{

    public RaycastHit previous;
    [SerializeField] private XRRayInteractor xr;
    public TextManager tm;
    public XRController xrC;
    // private InputDevice input;

    private void Start()
    {
        // input = xrC.inputDevice;
    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit rch;
    
        //
        if (xr.GetCurrentRaycastHit(out rch))
        {
            tm.ChangeLargeMenu(rch.transform.name);
        }
    }
}
