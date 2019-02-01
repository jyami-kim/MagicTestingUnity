using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block1 : MonoBehaviour
{
    private PlayerControl playerctrl;
    public static int put=0;
    public static int i = 0;

    public Image myImage;
    public Sprite mySecondImage;
    public Sprite myThirdImage;
    public Image inventory;
    public Image noneUsing;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "hole1")
        {
            i = 1;
        }
        if (collision.gameObject.name == "hole4")
        {
            i = 1;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        i = 0;
    }

    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (select.i == 1)
            {
                if (playerctrl.hit_ob == GameObject.Find("hole1"))
                {
                    put = 1;select.i = 0;
                    this.transform.position = GameObject.Find("hole11").transform.position;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole2"))
                {
                    put= 1;select.i = 0;
                    this.transform.position = GameObject.Find("hole22").transform.position;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole3"))
                {
                   put = 1;select.i = 0;
                    this.transform.position = GameObject.Find("hole33").transform.position;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole4"))
                {
                  put= 1;select.i = 0;
                    this.transform.position = GameObject.Find("hole44").transform.position;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange.a = 0;
                }
                if (playerctrl.hit_ob == GameObject.Find("hole5"))
                {
                   put = 1;select.i = 0;
                    this.transform.position = GameObject.Find("hole55").transform.position;
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    imageChange.a = 0;
                }
            }

            if(playerctrl.hit_ob == GameObject.Find("block11"))
            {
                put = 0;
                transform.position = GameObject.Find("hide").transform.position;
                inventory.sprite = myThirdImage;

                imageChange.a = 1;
            }

        }
    }
}
