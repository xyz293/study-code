using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 协程：协同程序 在主线程程序中 开启一个子程序 协同主程序
       异步执行，类似多线程，并不影响主程序的执行 
使用：
      1定义协同程序函数
          协同程序函数：
              返回值类型是IEnumerator是个接口
              函数体内必须含有yield return//允许你在某个点“暂停”函数，并在下一帧或其他条件满足后再继续。
               yield return null是等待一帧的时间
              yield return new WaitForSecond(填入所等待的时间)
               yield return StartCoroutine("协程函数")等待一个协程函数执行完毕
              yield return new WWW（url）等待一个网络下载任务执行完之后向下执行
              yield return new FixedUpdate() 等待固定更新函数执行完之后向下执行

               
      2开启协程：StartCoroutine()里面填入函数名称，会返回一个函数，这只是代表不带参数的
              StartCoroutine(time(1)); // 启动协程，传入参数1,带有参数的协程函数
      3关闭协程: StopAllCoroutine()关闭所有协程
                 StopCoroutine()需要一个IEnumerator类型的参数，或者一个字符串参数，代表协程函数名称
     四元数类的使用：
    1编辑器中编辑游戏物体时使用欧拉角
    2在使用脚本时，将欧拉角转换为四元数
    3将执行的四元素角转换为欧拉角
      transform.rotation = Quaternion.Euler(30, 0, 0)将欧拉角转换为四元数，将对象旋转30度
      transform.rotation.eulerAngles获取所对应的欧拉角
 
 */

public class camera : MonoBehaviour
{
    public Transform target; // 目标物体
    Vector3 offset; // 摄像机与目标物体的偏移量
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position; // 计算初始偏移量
        StartCoroutine(time(1)); // 启动协程，传入参数1
        transform.rotation = Quaternion.Euler(30, 0, 0); // 设置摄像机初始旋转角度为30度
    }
    IEnumerator time(int a)//协程函数
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offset; // 更新摄像机位置
    }
}
