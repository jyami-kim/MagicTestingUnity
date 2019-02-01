using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChange : MonoBehaviour {

    private PlayerControl playerctrl;
    

    public static int a=0;
    public Image myImage;
    public Sprite mySecondImage; 
    
    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }



    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (playerctrl.hit_ob == GameObject.Find("puz1"))
            {
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                myImage.sprite = mySecondImage;
                a=1; 
            }
        }
        





    }
}

