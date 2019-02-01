using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange2 : MonoBehaviour
{
    public static int a;
    //public GameObject imageObj;
    public Image myImage;
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
    private PlayerControl playerctrl;

    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
        //imageObj = GameObject.Find("inventory2");
        //myImage = imageObj.GetComponent<Image>();
    }



    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            //CompareTag("red")
            if (playerctrl.hit_ob == GameObject.Find("puz0"))
            {
                a++;
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage.sprite = mySecondImage;

            }
        }


    }
}

