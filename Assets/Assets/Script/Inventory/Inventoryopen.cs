using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventoryopen : MonoBehaviour {
    public GameObject panel;
    public bool InvenOpen;

    // Use this for initialization
    void Start () {
        panel.gameObject.SetActive(false);
        InvenOpen = false;
    }

    
    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump"))
        {
            if (InvenOpen == false)
            {
                panel.gameObject.SetActive(true);
                InvenOpen = true;
            }
            else
            {
                panel.gameObject.SetActive(false);
                InvenOpen = false;
            }
        }
    }
}
