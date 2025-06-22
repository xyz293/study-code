using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;//ʹ��xm���ļ����л�����
public class hero
{
    //����һ���ṹ��hero
    public string name; //����
    public int hp; //Ѫ��
    public int mp; //ħ��ֵ
    public int atk; //������
    public int def; //������
    public List<item> items= new List<item>(); //��Ʒ�б�
    public hero(string nmae,  int hp, int mp, int atk)
    {
        this.name = nmae;
        this.hp = hp;
        this.mp = mp;
        this.atk = atk;
        this.def = 0; //
    }
}
public struct item
{
    public string name; //��Ʒ����
    public int id;
    public item(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}
public class xmlload : MonoBehaviour
{
    // Start is called before the first frame update
    List<hero> heros= new List<hero>(); //����һ��Ӣ���б�  
    void Start()
    { // 
        var hero1 = new hero("hero1", 100, 50, 20); // ����һ��Ӣ��
        hero1.items.Add(new item("jian", 2)); // ����һ����Ʒ�б�
        hero1.items.Add(new item("bao", 1)); // �����Ʒ��Ӣ�۵���Ʒ�б���
        var hero2 = new hero("hero2", 120, 40, 25); // �޸����ֱ����ظ�
        hero2.items.Add(new item("fangju", 3)); // ��Ӳ�ͬ��Ʒ
        heros.Add(hero1);
        heros.Add(hero2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//�����ݱ��浽xml�ļ���
        {
            Debug.Log("�������ݵ�xml�ļ���"); //�����־
            writerxml("heros.xml"); //����writerxml�����������ļ���
        }   
    }
    void writerxml(string filename)//�ļ���
    {
        XmlDocument doc = new XmlDocument(); //����һ��xml�ĵ�����   
        var root = doc.CreateElement("root");//����root��ǩ
        doc.AppendChild(root); //�����ڵ���ӵ��ĵ���

        //�������hero��ǩ
        foreach (var herodate in heros)//����Ӣ������
        {
            var hero = doc.CreateElement("hero"); //����һ��hero��ǩ
            root.AppendChild(hero); //��hero��ǩ��ӵ����ڵ���

            //��д���ݵ�hero��ǩ��
            hero.SetAttribute("name", herodate.name);
            hero.SetAttribute("hp", herodate.hp.ToString());
            hero.SetAttribute("mp", herodate.mp.ToString());
            hero.SetAttribute("atk", herodate.atk.ToString());
            hero.SetAttribute("def", herodate.def.ToString());//XML Ԫ����ӻ��޸�һ�����ԣ��������� "name"������ֵ�� herodate.name




            var bag = doc.CreateElement("bag"); //����һ��items��ǩ
            hero.AppendChild(bag); //��bag��ǩ��ӵ�hero��ǩ��
            foreach (var itmes in herodate.items)
            {
                var item = doc.CreateElement("item"); //����һ��item��ǩ
                bag.AppendChild(item); //��item��ǩ��ӵ�bag��ǩ��
                item.SetAttribute("name", itmes.name);
                item.SetAttribute("id", itmes.id.ToString());//XML Ԫ����ӻ��޸�һ�����ԣ��������� "name"������ֵ�� itme.name

            }
        }
        doc.Save("D://code/" + filename); //����xml�ļ�
    }
}
