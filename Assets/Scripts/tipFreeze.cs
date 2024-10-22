using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipFreeze : MonoBehaviour
{
    public Rigidbody dart;
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

        if (collision.gameObject.layer != 7)
        {
            print("freeze");
            print(collision.gameObject.name);
            // dart.constraints = RigidbodyConstraints.FreezeAll;
           
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.layer != 7)
        {
            dart.constraints = RigidbodyConstraints.None;
            dart.constraints = RigidbodyConstraints.FreezeRotation;
            print("unfreee");
        }
    }
}
