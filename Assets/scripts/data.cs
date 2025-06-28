using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class data : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,100f)]
    public float health = 100f; // ÉúÃüÖµ
    public float def = 5;
    public float atk = 10;  
    public float add(float h)
    {
        health += h;
        health = Mathf.Clamp(health, 0, 100f);
        return health;

    } 
}
