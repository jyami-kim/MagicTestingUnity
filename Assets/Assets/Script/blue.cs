using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour {

    
    public GameObject player;
    private PlayerControl playerctrl;

    void Start () {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
        player = GameObject.Find("Player");
        GameObject.Find("Main Camrea").transform.position = new Vector3(0, 20, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            if (playerctrl.hit_ob.CompareTag("Box")) 
            { //ray에 hit한 collider의 Tag가 Box일 경우에
                playerctrl.hit_ob.transform.gameObject.SetActive(false);
                player.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
                player.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);

            }
        }
    }
    
}
