using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigid : MonoBehaviour
{
    /* 
     刚体组件（Rigidbody）：
     - 用于使物体受物理引擎控制
     - 可以设置质量、重力、摩擦等属性
     - 可以通过AddForce()方法施加力
     - 可以通过AddTorque()方法施加扭矩
     - 可以通过MovePosition()方法移动物体
     - 可以通过MoveRotation()方法旋转物体
    */
    // Start is called before the first frame update
    Rigidbody Rigidbody;
    void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody>(); //获取当前游戏对象的刚体组件
    }
    private void OnMouseUpAsButton()
    {
       Rigidbody.AddForce(transform.forward * 10); //为一个刚体添加一个向上的冲击力
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //如果按下空格键
        {
            //Rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse); //向上施加一个冲击力
            Rigidbody.velocity += Vector3.up * 10; //直接设置刚体的速度向上移动
        }
        float hor = Input.GetAxis("Horizontal"); //获取水平输入轴的值
        float ver = Input.GetAxis("Vertical"); //获取垂直输入轴的值
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime*5); //根据输入轴的值移动物体
    }
}
