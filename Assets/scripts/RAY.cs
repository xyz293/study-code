using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAY : MonoBehaviour
{/*
  1����һ�����߶���
  2������ײ��Ϣ����
  3�������� ��ȡ��ײ��Ϣ
  
  
  
  */
    // Start is called before the first frame update
    public Transform target; // Ŀ������
    bool isdraw; // �Ƿ���ײ������
    Vector3 hitpos;
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        { 
            Ray ray = new Ray(target.position,target.forward);//����һ�����߶������ΪĿ�������λ�ã�����ΪĿ�������ǰ��
            RaycastHit hit;// ����һ��������ײ��Ϣ����
            bool ishit =Physics.Raycast(ray, out hit); // �������ߣ�����Ϊ100f
            if (ishit)
            {
                //GameObject.Destroy(hit.collider.gameObject); // ���������ײ�����壬�����ٸ�����
                isdraw=true;
                hitpos = hit.point; // ��ȡ��ײ��λ��
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red; // ����ײ����������ɫ��Ϊ��ɫ
            }
        }
    }
    private void OnDrawGizmos()
    {
        if (isdraw)
        {
            Gizmos.DrawLine(target.position,hitpos); // ��������
        }
    }
}
