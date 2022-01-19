using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SceneController : MonoBehaviour
{
    public GameObject building;
    public GameObject BG;
    public Camera mainCamera;
    private Vector3 target;
    private Vector3 targetGravity;

    private bool isWhite = true;
    public bool buildisTouch;

    private Material build;
    private Color white;
    private Color black;
    // Start is called before the first frame update
    void Start()
    {
        white = GameObject.Find("white").GetComponent<Renderer>().material.color;
        black = GameObject.Find("black").GetComponent<Renderer>().material.color;
        build = GameObject.Find("building").GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //if (buildisTouch)
        //{
        //    building.transform.position = new Vector3(building.transform.position.x, -building.transform.position.y, building.transform.position.z);
        //    buildisTouch = false;
        //}
        target = new Vector3(building.transform.position.x, -building.transform.position.y, building.transform.position.z);
        targetGravity = -Physics.gravity;
        if (Input.GetMouseButtonDown(0))
        {
            if(isWhite)
            {
                BG.transform.DORotate(new Vector3(0, 0, 180), 0.5f);
                build.SetColor("_Color", white);
                isWhite = false;
            }
            else
            {
                isWhite = true;
                build.SetColor("_Color", black);
                BG.transform.DORotate(new Vector3(0, 0, 0), 0.5f);
            }
            //mainCamera.transform.DOShakePosition(0.5f);
            //player.transform.DOMove(target, 0.5f);
            //Physics.gravity = targetGravity;
        }

    }
}
