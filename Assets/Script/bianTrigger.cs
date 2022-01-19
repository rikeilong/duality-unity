using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bianTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.tag == "build")
        {
            GameObject.Find("BG").GetComponent<SceneController>().buildisTouch = true;
        }
    }
}
