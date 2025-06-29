using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camermove : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cameras;
    float field;
    float anglex;
    void Start()
    {
        cameras = transform.Find("q").GetComponent<Camera>();
        anglex = cameras.transform.localEulerAngles.x;   
        field = cameras.fieldOfView;
    }
    private void Update()
    {
        float x= Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");    
        transform.Translate(new Vector3(x, 0, y)*Time.deltaTime);
        float roll = Input.GetAxis("Mouse ScrollWheel");
        field -= roll*500f*Time.deltaTime;
        field = Mathf.Clamp(field, 20, 80);
        cameras.fieldOfView = field;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float mx = Input.GetAxis("mouse x");    
        float my = Input.GetAxis("mouse y");    
        transform.Rotate(0, mx * 5f, 0);
        anglex += my * 70f *Time.fixedDeltaTime ;
        anglex = Mathf.Clamp(anglex, -26, 12);
        cameras.transform.localEulerAngles = new Vector3(anglex, cameras.transform.localEulerAngles.y, cameras.transform.localEulerAngles.z);
    }
}
