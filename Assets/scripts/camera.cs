using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Э�̣�Эͬ���� �����̳߳����� ����һ���ӳ��� Эͬ������
       �첽ִ�У����ƶ��̣߳�����Ӱ���������ִ�� 
ʹ�ã�
      1����Эͬ������
          Эͬ��������
              ����ֵ������IEnumerator�Ǹ��ӿ�
              �������ڱ��뺬��yield return//��������ĳ���㡰��ͣ��������������һ֡����������������ټ�����
               yield return null�ǵȴ�һ֡��ʱ��
              yield return new WaitForSecond(�������ȴ���ʱ��)
               yield return StartCoroutine("Э�̺���")�ȴ�һ��Э�̺���ִ�����
              yield return new WWW��url���ȴ�һ��������������ִ����֮������ִ��
              yield return new FixedUpdate() �ȴ��̶����º���ִ����֮������ִ��

               
      2����Э�̣�StartCoroutine()�������뺯�����ƣ��᷵��һ����������ֻ�Ǵ�����������
              StartCoroutine(time(1)); // ����Э�̣��������1,���в�����Э�̺���
      3�ر�Э��: StopAllCoroutine()�ر�����Э��
                 StopCoroutine()��Ҫһ��IEnumerator���͵Ĳ���������һ���ַ�������������Э�̺�������
     ��Ԫ�����ʹ�ã�
    1�༭���б༭��Ϸ����ʱʹ��ŷ����
    2��ʹ�ýű�ʱ����ŷ����ת��Ϊ��Ԫ��
    3��ִ�е���Ԫ�ؽ�ת��Ϊŷ����
      transform.rotation = Quaternion.Euler(30, 0, 0)��ŷ����ת��Ϊ��Ԫ������������ת30��
      transform.rotation.eulerAngles��ȡ����Ӧ��ŷ����
 
 */

public class camera : MonoBehaviour
{
    public Transform target; // Ŀ������
    Vector3 offset; // �������Ŀ�������ƫ����
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position; // �����ʼƫ����
        StartCoroutine(time(1)); // ����Э�̣��������1
        transform.rotation = Quaternion.Euler(30, 0, 0); // �����������ʼ��ת�Ƕ�Ϊ30��
    }
    IEnumerator time(int a)//Э�̺���
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offset; // ���������λ��
    }
}
