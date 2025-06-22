using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*
       unity的常用类：
          time类：Time.deltaTime，表示上一帧到当前帧的时间间隔，保证游戏在不同设备上运行时的帧率一致性
                  Time.time表示运行时长
          debug类：
          Debug.Log("输出内容")，输出内容到控制台
          Debug.LogError("输出错误内容")，输出错误内容到控制台
          Debug.LogWarning("输出警告内容")，输出警告内容到控制台
           GameObject类: 
           GameObject.instantiate()，创建对象
           GanmeObject.Destroy()，销毁对象里面加入对象，销毁对象里面加入延时参数可以延时销毁
           GameObject.Find("对象名称")，查找场景中的对象，返回第一个找到的对象
            var a .AddComponent<组件类型>()，添加类组件到对象上，只会运行类里面的生命周期函数
            GameObject.FindGameObjectsWithTag("标签")，查找场景中所有带有指定标签的对象，返回一个数组
          input输入类：
          Input.GetAxis("Horizontal"); //获取水平输入轴的值
            Input.GetAxis("Vertical"); //获取垂直输入轴的值
            Input.GetKey(KeyCode.A); 按下调用一次，持续调用
            Input.GetKeyDown(KeyCode.A); 抬起调用一次
            Input.GetKeyUp(KeyCode.A); 按下之后，调用一次
            KeyCode.A是指某个按键的枚举值，表示A键
            Input.GetMouseButton(0); //鼠标左键按下持续调用
      if (Input.GetKeyDown(KeyCode.A))//按下A键
        {
             transform.localScale += Vector3.one; //每帧增加一个单位的缩放
        }
        if (Input.GetKey(KeyCode.P))//持续按下A键
        {
            transform.localScale += Vector3.one; //每帧增加一个单位的缩放
        }
        if (Input.GetKeyUp(KeyCode.A))//抬起A键
        {
            transform.localScale -= Vector3.one; //每帧减少一个单位的缩放
        }
        if (Input.GetKey(KeyCode.O))//持续按下A键
        {
            transform.localScale -= Vector3.one; //每帧增加一个单位的缩放
        }

          
           math类
           transform变换组件类
     */
    // Start is called before the first frame update
    void Start()
    {
       // GameObject [] a = GameObject.FindGameObjectsWithTag("cat");//通过标签获取

        //foreach (var b in a)
        {
            //b.AddComponent<rotate>();
        }
    }
    public GameObject game;

    // Update is called once per frame
    void Update()
    {
        //GameObject.Instantiate(gam e);
        //float hor=Input.GetAxis("Horizontal"); //获取水平输入轴的值
        //float ver = Input.GetAxis("Vertical"); //获取垂直输入轴的值
        //transform.Translate(new Vector3(hor, 0, ver)*Time.deltaTime);
      
        if (Input.GetMouseButton(0))//鼠标左键按下持续调用
        {
            Debug.Log(gameObject.name);
        }
        //var a =  Mathf.Clamp(1, -10, 10);//限制s的值在-10到10之间
        //Mathf.Sqrt(16);//计算平方根
        //Mathf.Pow(2, 3);//计算2的3次方
        var a = Mathf.Repeat(5.5f, 3);
        print(a);

    }
}
