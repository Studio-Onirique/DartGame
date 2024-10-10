using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Linq;
using System;

public class dart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        gameObject.GetComponent<Rigidbody>().freezeRotation = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;
    }
}
