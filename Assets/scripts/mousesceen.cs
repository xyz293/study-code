using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousesceen : MonoBehaviour
{
    /* 
     ����¼���
     OnMouseEnter()�������������ʱ����
     OnMouseExit()��������뿪����ʱ����
     OnMouseDown()�������������ʱ����
     OnMouseUp()��������ͷŶ���ʱ����
     OnMouseDrag()��������϶�����ʱ����
     OnMouseOver()���������ͣ�ڶ�����ʱ����
     OnMouseUpAsButton()���������벢̧��ʱ����
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseEnter()
    {
        // �����������ʱ����
        Debug.Log("�������˶��� ");
    }
    private void OnMouseExit()
    {
        // ������뿪����ʱ����
        Debug.Log("����뿪�˶��� ");
    }

    void OnMouseDown()
    {
        // �����������ʱ����
        Debug.Log("������˶��� ");
    }
    void OnMouseUp()
    {
        // ������ͷŶ���ʱ����
        Debug.Log("����ͷ��˶��� ");
    }
    void OnMouseDrag()
    {
        // ������϶�����ʱ����
        Debug.Log("����϶��˶��� ");
    }
    void OnMouseOver()
    {
        // �������ͣ�ڶ�����ʱ����
        Debug.Log("�����ͣ�ڶ����� ");
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("�����벢̧��");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
