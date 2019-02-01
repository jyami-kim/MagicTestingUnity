﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block2 : MonoBehaviour
{
    public GameObject player;
    private PlayerControl playerctrl;
    public static int i = 0,put=0;

    public Image myImage;
    public Sprite mySecondImage;
    public Sprite myThirdImage;
    public Image inventory;
    public Image noneUsing;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "hole2")
        {
            i = 1;
        }
      
    }

    void OnCollisionExit(Collision collision)
    {
        i = 0;
    }

    // Use this for initialization

    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetButtonDown("Fire2"))
        {

            if (select4.i == 1)
            {
                if (playerctrl.hit_ob == GameObject.Find("hole1"))
                {
                    put = 1;
                    this.transform.position = GameObject.Find("hole11").transform.position;
                    select4.i = 0;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange4.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole2"))
                {
                    put = 1;
                    this.transform.position = GameObject.Find("hole22").transform.position;
                    select4.i = 0;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange4.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole3"))
                {
                    put = 1;
                    this.transform.position = GameObject.Find("hole33").transform.position;
                    select4.i = 0;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange4.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole4"))
                {
                    put = 1;
                    this.transform.position = GameObject.Find("hole44").transform.position;
                    select4.i = 0;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange4.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole5"))
                {
                    put = 1;
                    this.transform.position = GameObject.Find("hole55").transform.position;
                    select4.i = 0;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange4.a = 0;
                }
            }
            if (playerctrl.hit_ob == GameObject.Find("block22"))
            {
                put = 0;
                transform.position = GameObject.Find("hide").transform.position;
                inventory.sprite = myThirdImage;

                imageChange4.a = 1;
            }

        }
    }
}
