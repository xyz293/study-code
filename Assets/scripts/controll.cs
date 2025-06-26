using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controll : MonoBehaviour
{
    public Animator anim; //给出一个动画器变量
    public data playerData; //给出一个数据变量，用于获取玩家的属性
    public Image hp;
    // Start is called before the first frame update
      public void attack()
    {
        anim.SetTrigger("attack"); 

    }
    public void hit()
    {
        anim.SetTrigger("hit");
    }   
}
