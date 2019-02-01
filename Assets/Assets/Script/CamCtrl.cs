using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamCtrl : MonoBehaviour {
    public GameObject player;
    private PlayerControl playerctrl;
    public static int ifUseOpener = 0;
    public Image myImage;
    public Sprite mySecondImage;
    public Image inventory;
    public Image noneUsing;
    //public ParticleSystem explosion;

    void Start(){
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            if (openerselect.i ==1)
            {
                if (playerctrl.hit_ob.CompareTag("Box"))
                { //ray에 hit한 collider의 Tag가 Box일 경우에
                    ifUseOpener = 1;
                    playerctrl.hit_ob.transform.gameObject.SetActive(false);
                    player.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
                    player.GetComponent<BoxCollider>().size = new Vector3(1,1,1);

                    player.transform.localScale = new Vector3(1,1,1);
                    //Instantiate(explosion, transform.position, Quaternion.identity);
                    inventory.sprite = mySecondImage;
                    myImage.sprite = mySecondImage;
                    noneUsing.sprite = mySecondImage;
                    openerselect.i = 0;
                    openerImageChange.a = 0;

                }
            }
        }
    }
}
