using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ButtonClick : MonoBehaviour {

    public GameObject doorObj;
    private float speed = 0.7f;
    private Vector3 targetPosition;

    public GameObject[] magicBtns;
    private btnList btnList;

    private bool isClick;
    private string btnNumberStr;
    private int btnNumber;


    // Use this for initialization
    void Start () {
        magicBtns = null;
        isClick = false;
        btnList = GameObject.Find("MagicBoard").GetComponent<btnList>();

        doorObj = GameObject.Find("Door");
        doorObj.transform.position = new Vector3(0, (float)2.5, 5); //시작 지점
        targetPosition = new Vector3(-3, (float)2.5, 5); //최종 지정

        GetComponent<Image>().color = new Color32(255, 246, 220, 255);
        btnNumberStr = gameObject.transform.name.Substring(6, 1);
        Int32.TryParse(btnNumberStr, out btnNumber);
    }
	
	// Update is called once per frame
	void Update () {
        if (btnList.check())
        { //정답을 맞췄을 때
            allBtnStop();
            doorObj.transform.position = Vector3.Lerp(doorObj.transform.position, targetPosition, speed*Time.deltaTime);
            Debug.Log("it is correct answer");
        }
    }

    public void btnClick() {

        if (isClick == false)
        {
            GetComponent<Image>().color = new Color32(36,36,36,255); //검은색
            isClick = true;
            btnList.Clicks[btnNumber] = true;
        }
        else {
            GetComponent<Image>().color = new Color32(255, 246, 220, 255); //살구색
            isClick = false;
            btnList.Clicks[btnNumber] = false;
        }

        Debug.Log("btnClick");

    }


    void allBtnStop()
    {
        if (magicBtns == null)
            magicBtns = GameObject.FindGameObjectsWithTag("btn");

        foreach (GameObject btn in magicBtns)
        {
            btn.GetComponent<Collider>().enabled = !btn.GetComponent<Collider>().enabled;
        }
    }
}
