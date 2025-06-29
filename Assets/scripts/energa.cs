using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class energa : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    Animator animator;
    public GameObject player;
    public GameObject[] pos;
    int index;
    public enum State
    {
        idle,
        atk,
    }
    State state;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if(state == State.idle)
            {
                int index = Random.Range(0, pos.Length);
                
                agent.destination = pos[index].transform.position;
                animator.SetTrigger("run");

            }
         if(state == State.atk)
        {
           
            agent.destination = player.transform.position;
            animator.SetTrigger("run");
          
        }
    }
    private void OnTriggerStay(Collider other)
    {
        state = State.atk;
    }
    private void OnTriggerExit(Collider other)
    {
        state = State.idle;
       
    }
}
