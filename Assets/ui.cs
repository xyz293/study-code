using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ui : MonoBehaviour
{
    // Start is called before the first frame update
    Image image;
    TMP_Text text;
    public float time;
    void Start()
    {
        image = transform.Find("he").GetComponent<Image>(); 
        text = transform.Find("txt").GetComponent <TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            StartCoroutine("Time");
           
        }
    }
    IEnumerator Time()
    {
        float cdtime = time;
        float fill;
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            time -=0.1f;
            text.text = time.ToString("0.0") + "s";
            fill =time/cdtime;
            fill = Mathf.Clamp(fill, 0, 1); 
            image.fillAmount = fill;
            if (time <=0)
            {
                image.fillAmount = 1;
                text.text = "";
                yield break;//不能在update里面恢复，因为两者是交替进行的

            }

        }
    }
}
