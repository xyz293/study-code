using JetBrains.Annotations;
using System;
using System.Collections;//�Ƿ��ͼ���
using System.Collections.Generic;//���ͼ���
using UnityEngine;

public class transform : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     1.������ű��ļ���������һ�µģ������޷�����unity��Ϸ������
     2����̳���MonoBehaviour���Ϳ��Թ���unity��Ϸ������
    ��ȡ����ķ�ʽ��
     this.GetComponent<�������>();
    ͨ����Ϸ�����ȡ����ķ�ʽ��

    �����ࣺvector2������vector3������
     */
    public Vector3 pos;//����һ����������pos������ΪVector3����ʾ��ά�ռ��е�λ��
    public Vector3 rotate;
    public Vector3 scale;
    public Transform sun;//����һ��Transform���͵ı���sun������������һ����Ϸ�����Transform���
    void Start()
    {
        print("��Ϸ�����ˣ�start�����ڵ�һ֡�� ��ǰ����һ��");
        print("Hello Unity");
        var a = GetComponent<Transform>();//��ȡ��ǰ��Ϸ�����Transform��������ű����ڵ���Ϸ����
        //var b = GameObject.Find("sun").GetComponent<Transform>();//ͨ����Ϸ�������ƻ�ȡ��Ϸ����
        //a.position= new Vector3(0, 0, 0);//���õ�ǰ��Ϸ�����λ��
        //b.position = new Vector3(0, 10, 0);//����sun��Ϸ�����λ��
        print(Vector2.Distance(new Vector3(0, 10, 20), new Vector3(10, 0, 30)));//������������֮��ľ���
        //a.position = pos;
        //a.localScale = scale;//���õ�ǰ��Ϸ���������
        //a.localEulerAngles = rotate;//���õ�ǰ��Ϸ�������ת�Ƕ�

    }
    public float speed = 10f;//����һ���ٶȱ�������ʾÿ֡�ƶ��ľ���
    internal readonly Vector3 position;

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1, 1, 0) * speed* Time.deltaTime);�ƶ�����Translate���������������Ϊ����ȥ�˶�


        //ʱ���ֵ ��Time.deltaTime����ʾ��һ֡����ǰ֡��ʱ��������֤��Ϸ�ڲ�ͬ�豸������ʱ��֡��һ����
        //transform.Rotate(new Vector3(0,1,0));
        //transform.Rotate(Vector3.up);
        gameObject.AddComponent<rotate>();//��y����ת���ٶ�Ϊspeed��ÿ֡��ת�ĽǶ�Ϊspeed*Time.deltaTime
        //gameObject.transform.RotateAround(sun.position,sun.up,15*Time.deltaTime);//��sun��up����ת10��
        //transform.localScale +=Vector3.one * Time.deltaTime;//ÿ֡����һ����λ������
    }
}

 