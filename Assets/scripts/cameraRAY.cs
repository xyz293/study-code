using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRAY : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     physics material:物理材质
      里面包括摩擦力和弹力    
     */
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition);//鼠标的位置
            //从摄像机向屏幕坐标点创建一条射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//是从摄像机向屏幕坐标点创建一条射线 
            RaycastHit hit;//可直接使用RaycastHit来获取射线碰撞到的物体的信息
            bool ishit = Physics.Raycast(ray, out hit, 100f);//发射射线，长度为100f
            if (ishit)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(ray.direction * 1000f);//给出射线方向的刚体施加一个力s
                }
            }
        }
    }
}
