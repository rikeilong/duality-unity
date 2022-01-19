using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personCtrl : MonoBehaviour
{
    private int lastKey=100;//记录上一次按下的按钮
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //跳转
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) *370);
        }
        //前走
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(1,0,0) * Time.deltaTime*5,Space.World);
            //判断是否需要调头
            if (lastKey != (int)KeyCode.D)
            {
                this.transform.Rotate(0, 180, 0);
            }
            lastKey = (int)KeyCode.D;
        }
        //后走
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime*5, Space.World);
            //判断是否需要调头
            if (lastKey != (int)KeyCode.A)
            {
                this.transform.Rotate(0, 180, 0);
            }
            lastKey = (int)KeyCode.A;
        }
    }
}
