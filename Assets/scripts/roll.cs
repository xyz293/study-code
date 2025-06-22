using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    /*
     is Trigger：bool类型，表示是否为触发器，如果为true，则不会发生碰撞，而是触发OnTriggerEnter、OnTriggerExit等事件
    触发器 在检测碰撞时没有物理碰撞效果（只做检测没有碰撞效果）
     检测碰撞函数：
    参数表是碰撞的其他物体的碰撞器组件
         onCollisionEnter：当碰撞发生时调用
            onCollisionExit：当碰撞结束时调用
            onCollisionStay：当碰撞持续时调用
          ontriggerEnter：当物体进入时调用
            onTriggerExit：当物体退出时调用
            onTriggerStay：当物体持续时调用
     
     
     
     */
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            GameObject.Destroy(other.gameObject); //销毁碰撞到的物体
        }
    }

    Rigidbody Rigidbody;
    public float speed;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        GameObject[] a = GameObject.FindGameObjectsWithTag("coin"); //查找所有标签为coin的物体
        foreach (var b in a)
        {
            b.AddComponent<rotate>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float hor=Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(hor,0,ver)*Time.deltaTime); //根据输入轴的值施加力
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse); //向上施加一个冲击力
        }
    }
}
