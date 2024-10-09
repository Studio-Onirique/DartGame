using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Linq;
using System;

public class dart : MonoBehaviour
{
    public HandGrabInteractor _dart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(_dart.IsGrabbing);
        /*print(_dart.Interactors.An);
        if (_dart.Interactors.Any())
        {
            print(_dart.Interactors.First().gameObject.name);
        }
        if (_dart.Interactors.FirstOrDefault<HandGrabInteractor>() != null)
        {
            print("partyyy!!!");
        }*/
    }
}
