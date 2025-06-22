using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousesceen : MonoBehaviour
{
    /* 
     鼠标事件：
     OnMouseEnter()：当鼠标进入对象时调用
     OnMouseExit()：当鼠标离开对象时调用
     OnMouseDown()：当鼠标点击对象时调用
     OnMouseUp()：当鼠标释放对象时调用
     OnMouseDrag()：当鼠标拖动对象时调用
     OnMouseOver()：当鼠标悬停在对象上时调用
     OnMouseUpAsButton()：当鼠标进入并抬起时调用
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseEnter()
    {
        // 当鼠标进入对象时调用
        Debug.Log("鼠标进入了对象 ");
    }
    private void OnMouseExit()
    {
        // 当鼠标离开对象时调用
        Debug.Log("鼠标离开了对象 ");
    }

    void OnMouseDown()
    {
        // 当鼠标点击对象时调用
        Debug.Log("鼠标点击了对象 ");
    }
    void OnMouseUp()
    {
        // 当鼠标释放对象时调用
        Debug.Log("鼠标释放了对象 ");
    }
    void OnMouseDrag()
    {
        // 当鼠标拖动对象时调用
        Debug.Log("鼠标拖动了对象 ");
    }
    void OnMouseOver()
    {
        // 当鼠标悬停在对象上时调用
        Debug.Log("鼠标悬停在对象上 ");
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("鼠标进入并抬起");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
