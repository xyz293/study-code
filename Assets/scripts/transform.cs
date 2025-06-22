using JetBrains.Annotations;
using System;
using System.Collections;//非泛型集合
using System.Collections.Generic;//泛型集合
using UnityEngine;

public class transform : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     1.类名与脚本文件名必须是一致的，否则无法挂在unity游戏对象上
     2，类继承了MonoBehaviour，就可以挂在unity游戏对象上
    获取组件的方式：
     this.GetComponent<组件名称>();
    通过游戏对象获取组件的方式：

    向量类：vector2（）；vector3（）；
     */
    public Vector3 pos;//定义一个向量变量pos，类型为Vector3，表示三维空间中的位置
    public Vector3 rotate;
    public Vector3 scale;
    public Transform sun;//定义一个Transform类型的变量sun，用于引用另一个游戏对象的Transform组件
    void Start()
    {
        print("游戏运行了，start函数在第一帧更 新前调用一次");
        print("Hello Unity");
        var a = GetComponent<Transform>();//获取当前游戏对象的Transform组件，即脚本所在的游戏对象
        //var b = GameObject.Find("sun").GetComponent<Transform>();//通过游戏对象名称获取游戏对象
        //a.position= new Vector3(0, 0, 0);//设置当前游戏对象的位置
        //b.position = new Vector3(0, 10, 0);//设置sun游戏对象的位置
        print(Vector2.Distance(new Vector3(0, 10, 20), new Vector3(10, 0, 30)));//计算两个向量之间的距离
        //a.position = pos;
        //a.localScale = scale;//设置当前游戏对象的缩放
        //a.localEulerAngles = rotate;//设置当前游戏对象的旋转角度

    }
    public float speed = 10f;//定义一个速度变量，表示每帧移动的距离
    internal readonly Vector3 position;

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1, 1, 0) * speed* Time.deltaTime);移动作用Translate方法，以这个向量为方向去运动


        //时间插值 ：Time.deltaTime，表示上一帧到当前帧的时间间隔，保证游戏在不同设备上运行时的帧率一致性
        //transform.Rotate(new Vector3(0,1,0));
        //transform.Rotate(Vector3.up);
        gameObject.AddComponent<rotate>();//绕y轴旋转，速度为speed，每帧旋转的角度为speed*Time.deltaTime
        //gameObject.transform.RotateAround(sun.position,sun.up,15*Time.deltaTime);//绕sun的up轴旋转10度
        //transform.localScale +=Vector3.one * Time.deltaTime;//每帧增加一个单位的缩放
    }
}

 