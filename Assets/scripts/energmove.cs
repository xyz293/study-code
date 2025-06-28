using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energmove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Rigidbody;
    public transform targets;
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
     public void moves()
    {
        Debug.Log("move");
        if(Rigidbody)
        {
            Rigidbody.velocity = (transform.forward)*2;
        }
    }
}
