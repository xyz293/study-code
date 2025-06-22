using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 生命周期函数 : MonoBehaviour
{
    /*
         生命周期函数:对象在生存到死亡期间所调用的函数称之为生命周期函数
    prefabs:预制体资源 unity特殊资源 用于批量创建 批量修改对象的一种预设

     
     
     
     
     
     
     
     */
    private void Awake()//当对象被创建时调用（只有一次）,预制体再被创立的时候也会调用一次Awake函数
    {
        // 在脚本实例被加载时调用
        // 适合初始化变量或状态
        //Debug.Log("Awake called");
        print("Awake函数被调用了");
    }

    // Start is called before the first frame update

    void Start()//当对象被激活的时候调用（只有一次）
    {
        // 在脚本实例被启用时调用
        // 适合初始化游戏状态
        //Debug.Log("Start called");
        print("Start函数被调用了");
    }

    // Update is called once per frame
    void Update()//每一帧调用一次，帧率越高调用越频繁
    {
    }
    private void LateUpdate()//紧接update之后调用一次
    {

    }
    private void FixedUpdate()//固定时间内会调用一次
    {

    }

    private void OnEnable()//每当对象被启用时调用
    {
        print("对象被启用，OnEnable函数被调用了");
    }
    private void OnDisable()//每当对象被禁用时调用
    {
           print("对象被禁用，OnDisable函数被调用了");
    }

    private void OnDestroy()//当对象被销毁时调用
    {
        print("对象被销毁，OnDestroy函数被调用了");
    }


}
