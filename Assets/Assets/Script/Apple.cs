using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    private float speed = 1f;
    private Vector3 targetPosition;
    public GameObject wallObj;
    private PlayerControl playerctrl;

    private bool isAppleClick;

    // Use this for initialization
    void Start () {
        isAppleClick = false;
        wallObj = GameObject.Find("leftWall");
        wallObj.transform.localPosition = new Vector3((float)0.3, 23, 0); //벽 시작 지점
        targetPosition = new Vector3((float)0.3, 70, 0); //벽 최종 지정

        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
        transform.localPosition = new Vector3(-1, (float)-1.94, (float)1.7);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAppleClick) {
            wallObj.transform.localPosition = Vector3.Lerp(wallObj.transform.localPosition, targetPosition, speed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (playerctrl.hit_ob.CompareTag("Apple"))
            {
                transform.localPosition = new Vector3(-1, (float)-1.94, (float)0.75);
                isAppleClick = true;
            }
        }
    }


}
