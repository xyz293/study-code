using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRAY : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     physics material:�������
      �������Ħ�����͵���    
     */
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition);//����λ��
            //�����������Ļ����㴴��һ������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//�Ǵ����������Ļ����㴴��һ������ 
            RaycastHit hit;//��ֱ��ʹ��RaycastHit����ȡ������ײ�����������Ϣ
            bool ishit = Physics.Raycast(ray, out hit, 100f);//�������ߣ�����Ϊ100f
            if (ishit)
            {
                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(ray.direction * 1000f);//�������߷���ĸ���ʩ��һ����s
                }
            }
        }
    }
}
