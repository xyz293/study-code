using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    private void OnAnimatorMove()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3 (input, 0, 0)*Time.deltaTime);
        a.SetFloat("run", input);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            a.SetTrigger("jump");
        }
    }
}
