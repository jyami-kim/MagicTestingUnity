using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openerImageChange : MonoBehaviour
{
    public static int a;
   // public GameObject imageObj;
    public Image myImage;
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
    public GameObject player;
    private PlayerControl playerctrl;
    public Sprite none;

    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
       // imageObj = GameObject.Find("inventory5");
       // myImage = imageObj.GetComponent<Image>();
    }

    void Update()
    {
        if (OpenBox.open>0) {         
            if (Input.GetButtonDown("Fire2"))
            {

                if (playerctrl.hit_ob.CompareTag("opener"))
                {
                    playerctrl.hit_ob.transform.gameObject.SetActive(false);
                    myImage.sprite = mySecondImage;
                    a++;
                }

            }
        }
        

    }
}

