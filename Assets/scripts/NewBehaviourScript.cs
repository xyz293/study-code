using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*
       unity�ĳ����ࣺ
          time�ࣺTime.deltaTime����ʾ��һ֡����ǰ֡��ʱ��������֤��Ϸ�ڲ�ͬ�豸������ʱ��֡��һ����
                  Time.time��ʾ����ʱ��
          debug�ࣺ
          Debug.Log("�������")��������ݵ�����̨
          Debug.LogError("�����������")������������ݵ�����̨
          Debug.LogWarning("�����������")������������ݵ�����̨
           GameObject��: 
           GameObject.instantiate()����������
           GanmeObject.Destroy()�����ٶ����������������ٶ������������ʱ����������ʱ����
           GameObject.Find("��������")�����ҳ����еĶ��󣬷��ص�һ���ҵ��Ķ���
            var a .AddComponent<�������>()�����������������ϣ�ֻ��������������������ں���
            GameObject.FindGameObjectsWithTag("��ǩ")�����ҳ��������д���ָ����ǩ�Ķ��󣬷���һ������
          input�����ࣺ
          Input.GetAxis("Horizontal"); //��ȡˮƽ�������ֵ
            Input.GetAxis("Vertical"); //��ȡ��ֱ�������ֵ
            Input.GetKey(KeyCode.A); ���µ���һ�Σ���������
            Input.GetKeyDown(KeyCode.A); ̧�����һ��
            Input.GetKeyUp(KeyCode.A); ����֮�󣬵���һ��
            KeyCode.A��ָĳ��������ö��ֵ����ʾA��
            Input.GetMouseButton(0); //���������³�������
      if (Input.GetKeyDown(KeyCode.A))//����A��
        {
             transform.localScale += Vector3.one; //ÿ֡����һ����λ������
        }
        if (Input.GetKey(KeyCode.P))//��������A��
        {
            transform.localScale += Vector3.one; //ÿ֡����һ����λ������
        }
        if (Input.GetKeyUp(KeyCode.A))//̧��A��
        {
            transform.localScale -= Vector3.one; //ÿ֡����һ����λ������
        }
        if (Input.GetKey(KeyCode.O))//��������A��
        {
            transform.localScale -= Vector3.one; //ÿ֡����һ����λ������
        }

          
           math��
           transform�任�����
     */
    // Start is called before the first frame update
    void Start()
    {
       // GameObject [] a = GameObject.FindGameObjectsWithTag("cat");//ͨ����ǩ��ȡ

        //foreach (var b in a)
        {
            //b.AddComponent<rotate>();
        }
    }
    public GameObject game;

    // Update is called once per frame
    void Update()
    {
        //GameObject.Instantiate(gam e);
        //float hor=Input.GetAxis("Horizontal"); //��ȡˮƽ�������ֵ
        //float ver = Input.GetAxis("Vertical"); //��ȡ��ֱ�������ֵ
        //transform.Translate(new Vector3(hor, 0, ver)*Time.deltaTime);
      
        if (Input.GetMouseButton(0))//���������³�������
        {
            Debug.Log(gameObject.name);
        }
        //var a =  Mathf.Clamp(1, -10, 10);//����s��ֵ��-10��10֮��
        //Mathf.Sqrt(16);//����ƽ����
        //Mathf.Pow(2, 3);//����2��3�η�
        var a = Mathf.Repeat(5.5f, 3);
        print(a);

    }
}
