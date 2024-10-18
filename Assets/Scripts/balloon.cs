using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class balloon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PikePike")
        {
            Destroy(gameObject);
        }
    }
}
