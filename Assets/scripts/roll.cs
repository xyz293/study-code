using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    /*
     is Trigger��bool���ͣ���ʾ�Ƿ�Ϊ�����������Ϊtrue���򲻻ᷢ����ײ�����Ǵ���OnTriggerEnter��OnTriggerExit���¼�
    ������ �ڼ����ײʱû��������ײЧ����ֻ�����û����ײЧ����
     �����ײ������
    ����������ײ�������������ײ�����
         onCollisionEnter������ײ����ʱ����
            onCollisionExit������ײ����ʱ����
            onCollisionStay������ײ����ʱ����
          ontriggerEnter�����������ʱ����
            onTriggerExit���������˳�ʱ����
            onTriggerStay�����������ʱ����
     
     
     
     */
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            GameObject.Destroy(other.gameObject); //������ײ��������
        }
    }

    Rigidbody Rigidbody;
    public float speed;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        GameObject[] a = GameObject.FindGameObjectsWithTag("coin"); //�������б�ǩΪcoin������
        foreach (var b in a)
        {
            b.AddComponent<rotate>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float hor=Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(hor,0,ver)*Time.deltaTime); //�����������ֵʩ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse); //����ʩ��һ�������
        }
    }
}
