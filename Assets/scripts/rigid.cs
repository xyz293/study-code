using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigid : MonoBehaviour
{
    /* 
     ���������Rigidbody����
     - ����ʹ�����������������
     - ��������������������Ħ��������
     - ����ͨ��AddForce()����ʩ����
     - ����ͨ��AddTorque()����ʩ��Ť��
     - ����ͨ��MovePosition()�����ƶ�����
     - ����ͨ��MoveRotation()������ת����
    */
    // Start is called before the first frame update
    Rigidbody Rigidbody;
    void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody>(); //��ȡ��ǰ��Ϸ����ĸ������
    }
    private void OnMouseUpAsButton()
    {
       Rigidbody.AddForce(transform.forward * 10); //Ϊһ���������һ�����ϵĳ����
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //������¿ո��
        {
            //Rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse); //����ʩ��һ�������
            Rigidbody.velocity += Vector3.up * 10; //ֱ�����ø�����ٶ������ƶ�
        }
        float hor = Input.GetAxis("Horizontal"); //��ȡˮƽ�������ֵ
        float ver = Input.GetAxis("Vertical"); //��ȡ��ֱ�������ֵ
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime*5); //�����������ֵ�ƶ�����
    }
}
