using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvenSelect : MonoBehaviour {

    public int selectbtn;
    GameObject[] invents;

    // Use this for initialization
    void Start () {
        selectbtn = 1;
        invents = GameObject.FindGameObjectsWithTag("invenback");
    }

    void moving() {
        if (Input.GetAxis("Horizontal") > 0 && Input.GetButtonDown("Horizontal")) //오른쪽 방향키
        {
            if (selectbtn < 10)
            {
                switch (selectbtn)
                {
                    case 9:
                        selectbtn = 9;
                        break;
                    default:
                        selectbtn += 1;
                        break;
                }
            }
        }
        else if (Input.GetAxis("Horizontal") < 0 && Input.GetButtonDown("Horizontal"))
        { // 왼쪽 방향키
            switch (selectbtn)
            {
                case 1:
                case 4:
                case 7:
                    selectbtn = 0;
                    break;
                case 0:
                    selectbtn = 0;
                    break;
                default:
                    selectbtn -= 1;
                    break;
            }
        }

        if (Input.GetAxis("Vertical") > 0 && Input.GetButtonDown("Vertical")) // 위쪽 방향키
        {
            switch (selectbtn)
            {
                case 0:
                    selectbtn = 0;
                    break;
                case 1:
                    selectbtn = 0;
                    break;
                case 2:
                    selectbtn = 7;
                    break;
                case 3:
                    selectbtn = 8;
                    break;
                default:
                    selectbtn -= 3;
                    break;
            }
        }
        else if (Input.GetAxis("Vertical") < 0 && Input.GetButtonDown("Vertical"))
        { // 아래쪽 방향키
            if (selectbtn < 10)
            {
                switch (selectbtn)
                {
                    case 0:
                        selectbtn = 1;
                        break;
                    case 7:
                        selectbtn = 2;
                        break;
                    case 8:
                        selectbtn = 3;
                        break;
                    case 9:
                        selectbtn = 9;
                        break;
                    default:
                        selectbtn += 3;
                        break;
                }
            }
        }
    }

    void colorselect() {
        for (int i = 0; i < invents.Length; i++)
        {
            int compare = int.Parse(invents[i].transform.parent.name[5].ToString());
            if (compare == selectbtn)
            {
                invents[i].GetComponent<Image>().color = new Color32(48, 28, 19, 255);
                continue;
            }
            if (invents[i].name.Equals("Rotation"))
            {
                invents[i].GetComponent<Image>().color = new Color32(139, 123, 112, 255);
            }
            else
            {
                invents[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        moving();
        colorselect();

        if (Input.GetButtonDown("Fire2")) {
            switch (selectbtn) {
                case 1:
                    GameObject.Find("inv1").GetComponent<select>().bigImage();
                    break;
                case 2:
                    GameObject.Find("inv2").GetComponent<select2>().bigImage();
                    break;
     
                case 3:
                    GameObject.Find("inv3").GetComponent<select3>().bigImage();
                    break;
                case 4:
                    GameObject.Find("inv4").GetComponent<select4>().bigImage();
                    break;
                case 5:
                    GameObject.Find("inv5").GetComponent<select5>().bigImage();
                    break;

                case 6:
                    GameObject.Find("inv6").GetComponent<openerselect>().bigImage();
                    break;
                case 0:
                    GameObject.Find("Rotation").GetComponent<Rotation>().rotation();
                    break;
            }
        }

    }
}
