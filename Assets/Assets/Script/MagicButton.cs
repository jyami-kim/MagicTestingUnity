using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MagicButton : MonoBehaviour {

    public GameObject doorObj;
    private float speed = 0.7f;
    private Vector3 targetPosition;

    public GameObject[] magicBtns;
    private BtnList btnList;

    private string btnNumberStr;
    private int btnNumber;

    private PlayerControl playerctrl;

    public Material btnColorBlack;
    public Material btnColorBeige;

    // Use this for initialization
    void Start () {

        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();

        magicBtns = null;
        btnList = GameObject.Find("MagicBoard").GetComponent<BtnList>();

        doorObj = GameObject.Find("MagicDoor");
        doorObj.transform.localPosition = new Vector3(-1, (float)-0.28, (float)-0.26); //시작 지점
        targetPosition = new Vector3(-1, (float)-0.28, (float)-0.1); //최종 지정

    }
	
	// Update is called once per frame
	void Update () {
        if (btnList.check())
        { //정답을 맞췄을 때
            allBtnStop();
            doorObj.transform.localPosition = Vector3.Lerp(doorObj.transform.localPosition, targetPosition, speed * Time.deltaTime);
            Debug.Log("it is correct answer");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (playerctrl.hit_ob != null) {
                if (playerctrl.hit_ob.CompareTag("MagicBtn"))
                {

                    btnNumberStr = playerctrl.hit_ob.name.Substring(6, 1);
                    System.Int32.TryParse(btnNumberStr, out btnNumber);
                    btnClick(btnNumber);
                }
            }

        }
    }

    public void btnClick(int btnNumber)
    {

        if (btnList.Clicks[btnNumber] == false)
        {
            GameObject.Find(playerctrl.hit_ob.name).GetComponent<MeshRenderer>().material = btnColorBlack;
            //검은색
            btnList.Clicks[btnNumber] = true;
        }
        else
        {
            GameObject.Find(playerctrl.hit_ob.name).GetComponent<MeshRenderer>().material = btnColorBeige;
            //살구색
            btnList.Clicks[btnNumber] = false;
        }

        Debug.Log(btnNumber + "btnClick");

    }

    void allBtnStop()
    {
        if (magicBtns == null)
            magicBtns = GameObject.FindGameObjectsWithTag("MagicBtn");

        foreach (GameObject btn in magicBtns)
        {
            btn.GetComponent<Collider>().enabled = !btn.GetComponent<Collider>().enabled;
        }
    }
}
