using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controll : MonoBehaviour
{
    public Animator anim; //����һ������������
    public data playerData; //����һ�����ݱ��������ڻ�ȡ��ҵ�����
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
