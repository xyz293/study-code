using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorevent : MonoBehaviour
{
    // Start is called before the first frame update
    public energmove a;
    public GameObject player;
    void Start()
    {
        
    }

      void EQEnable(string name)
    {
        if (a)
        {
            Instantiate(a, player.transform.position, Quaternion.identity);
            a.moves();
           
        }
        print(name);

    }
    // Update is called once per frame
   
}
