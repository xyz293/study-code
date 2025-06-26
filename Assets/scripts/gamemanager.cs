using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,10f)]
    public float i;
    public controll a;
    public controll b;
    public enum State
    {
        idel,
        playera,
        playerb,
        finish,
    }
    public State state;
    void Start()
    {
        a.attack();
        b.hit();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(state == State.idel)
            {
                state = State.playera;
                a.attack();
                b.hp.fillAmount = ((b.playerData.health) / 100f) -(a.playerData.atk) / 100f;

            }
            else if (state == State.playerb)
            {
                a.attack();
                b.hit();
                b.playerData.health = b.playerData.add(10);

            }
            else
            {
                state = State.playerb;
                b.attack();
                a.hp.fillAmount = ((a.playerData.health) / 100f) -(a.playerData.atk) / 100f;
            }
        }
    }
}
