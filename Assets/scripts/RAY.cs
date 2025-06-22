using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAY : MonoBehaviour
{/*
  1创建一个射线对象
  2场景碰撞信息对象
  3发射射线 获取碰撞信息
  
  
  
  */
    // Start is called before the first frame update
    public Transform target; // 目标物体
    bool isdraw; // 是否碰撞到物体
    Vector3 hitpos;
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        { 
            Ray ray = new Ray(target.position,target.forward);//创建一个射线对象，起点为目标物体的位置，方向为目标物体的前方
            RaycastHit hit;// 创建一个射线碰撞信息对象
            bool ishit =Physics.Raycast(ray, out hit); // 发射射线，长度为100f
            if (ishit)
            {
                //GameObject.Destroy(hit.collider.gameObject); // 如果射线碰撞到物体，则销毁该物体
                isdraw=true;
                hitpos = hit.point; // 获取碰撞点位置
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red; // 将碰撞到的物体颜色变为红色
            }
        }
    }
    private void OnDrawGizmos()
    {
        if (isdraw)
        {
            Gizmos.DrawLine(target.position,hitpos); // 绘制射线
        }
    }
}
