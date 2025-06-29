using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    Rigidbody rb;
    public float movespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnAnimatorMove()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, 0, y) * movespeed* Time.deltaTime);

        animator.SetFloat("walk", x);
        animator.SetFloat("walk1", y);

        animator.SetFloat("walk2", x);
        animator.SetFloat("walk3", y);
    }
}

