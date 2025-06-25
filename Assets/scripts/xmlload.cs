using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;
using UnityEngine.UI;//使用xm的文件序列化功能
using System.IO; //使用文件输入输出功能

public class hero
{
    //定义一个结构体hero
    public string name; //名字
    public int hp; //血量
    public int mp; //魔法值
    public int atk; //攻击力
    public int def; //防御力
    public List<item> items= new List<item>(); //物品列表
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
    public string name; //物品名称
    public int id;
    public item(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}
public class xmlload : MonoBehaviour
{
    string xmlpath = "D://code/heros.xml"; //xml文件路径
    // Start is called before the first frame update
    List<hero> heros= new List<hero>(); //创建一个英雄列表  
    public Text xmltext;//数据显示组件
    string url;
    void Start()
    { // 
        var hero1 = new hero("hero1", 100, 50, 20); // 创建一个英雄
        hero1.items.Add(new item("jian", 2)); // 创建一个物品列表
        hero1.items.Add(new item("bao", 1)); // 添加物品到英雄的物品列表中
        var hero2 = new hero("hero2", 120, 40, 25); // 修改名字避免重复
        hero2.items.Add(new item("fangju", 3)); // 添加不同物品
        heros.Add(hero1);
        heros.Add(hero2);
        Debug.Log("位置" + Application.dataPath);//获取asset文件的路径
        url = Application.dataPath + "/xml/";
        if(!Directory.Exists(url)) //文件夹是否存在
        {
            Directory.CreateDirectory(url); //；里面是文件名称
        }
        else
        {
            if (File.Exists(url + "file.txt")){
                var a = File.ReadAllText(url + "file.txt"); //读取文件内容
                Debug.Log("文件内容：" + a); //输出文件内容
                File.Delete(url + "file.txt"); //删除文件

                //File.Create()创建文件
                //File.WriteAllText(文件，内容)写入文件内容
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//将数据保存到xml文件中
        {
            Debug.Log("保存数据到xml文件中"); //输出日志
            writerxml("heros.xml"); 
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            readxmlfile(xmlpath); 
        }
    }
    void writerxml(string filename)//文件名
    {
        XmlDocument doc = new XmlDocument(); //创建一个xml文档对象   
        var root = doc.CreateElement("root");//创建root标签
        doc.AppendChild(root); //将根节点添加到文档中

        //创建多个hero标签
        foreach (var herodate in heros)//遍历英雄数据
        {
            var hero = doc.CreateElement("hero"); //创建一个hero标签
            root.AppendChild(hero); //将hero标签添加到根节点中

            //填写数据到hero标签中
            hero.SetAttribute("name", herodate.name);
            hero.SetAttribute("hp", herodate.hp.ToString());
            hero.SetAttribute("mp", herodate.mp.ToString());
            hero.SetAttribute("atk", herodate.atk.ToString());
            hero.SetAttribute("def", herodate.def.ToString());//XML 元素添加或修改一个属性，属性名是 "name"，属性值是 herodate.name




            var bag = doc.CreateElement("bag"); //创建一个items标签
            hero.AppendChild(bag); //将bag标签添加到hero标签中
            foreach (var itmes in herodate.items)
            {
                var item = doc.CreateElement("item"); //创建一个item标签
                bag.AppendChild(item); //将item标签添加到bag标签中
                item.SetAttribute("name", itmes.name);
                item.SetAttribute("id", itmes.id.ToString());

            }
        }
        doc.Save("D://code/" + filename); //保存xml文件
    }
    void readxmlfile(string filename) 
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filename); //加载xml文件

        var root = doc.SelectSingleNode("root") as XmlElement; //获取根节点 
        foreach(XmlElement hero in  root.ChildNodes)
        {
            //填写数据到界面里面
            xmltext.text += hero.GetAttribute("name") + ":{";
            var bag = hero.SelectSingleNode("bag") as XmlElement; //获取bag节点
            foreach(XmlElement item in bag.ChildNodes)
            {
                xmltext.text += item.GetAttribute("name") + " ";

                xmltext.text += "}\n";

            }
            
        }

    }
}
