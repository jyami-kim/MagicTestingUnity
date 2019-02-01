using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    private Vector3 ScreenCenter;
    public GameObject hit_ob;
    private int speed;
    public GameObject camOb;
    public bool isinvenopen;
    public ParticleSystem explosion;

    // Use this for initialization
    void Start () {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        speed = 10;
    }

    void movecam() {
        if (Input.GetButton("Vertical"))
        {
            float v = Input.GetAxis("Vertical");
            if (v < 0)
            {
                Camera.main.transform.Translate(Vector3.back * speed * Time.deltaTime);
                camOb.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            else if (v > 0)
            {
                Camera.main.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                camOb.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
        }
        else if (Input.GetButton("Horizontal"))
        {
            float h = Input.GetAxis("Horizontal");
            if (h < 0)
            {
                Camera.main.transform.Translate(Vector3.left * speed * Time.deltaTime);
                camOb.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            else if (h > 0)
            {
                Camera.main.transform.Translate(Vector3.right * speed * Time.deltaTime);
                camOb.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
        }

        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            hit_ob = hit.collider.gameObject;
        }
        else {
            hit_ob = null;
        }
    }

    // Update is called once per frame
    void Update () {
        isinvenopen = GameObject.Find("Panel").GetComponent<Inventoryopen>().InvenOpen;
        if (!isinvenopen) {
            movecam();
            if (CamCtrl.ifUseOpener == 1)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                CamCtrl.ifUseOpener = 0;
            }
        }
        
	}

}

