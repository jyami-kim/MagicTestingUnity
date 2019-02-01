using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//답: 1037
public class DoorQuiz1 : MonoBehaviour {

    private PlayerControl playerctrl;
    public GameObject sp1, sp2, sp3, sp4;
    public GameObject door1;
    int count = 0, correct = 0;
    public GameObject n0, n1, n2, n3, n4, n5, n6, n7, n8, n9;
    //int a = 0, b = 0, c = 0, d = 0;

    // Use this for initialization
    void Start()
    {
        playerctrl = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2")) {

            if (count == 0)
            {
                if (playerctrl.hit_ob == n1)
                {
                    count++; correct++; sp1.SetActive(false);
                }
                else if ((playerctrl.hit_ob == n2 || playerctrl.hit_ob == n3 || playerctrl.hit_ob == n4 ||
                        playerctrl.hit_ob == n5 || playerctrl.hit_ob == n6 || playerctrl.hit_ob == n7 ||
                        playerctrl.hit_ob == n8 || playerctrl.hit_ob == n9 || playerctrl.hit_ob == n0))
                {
                    count++; sp1.SetActive(false);
                }
            }
            else if (count == 1)
            {
                if (playerctrl.hit_ob == n0)
                {
                    count++; correct++; sp2.SetActive(false);
                }
                else if ((playerctrl.hit_ob == n1 || playerctrl.hit_ob == n2 || playerctrl.hit_ob == n3 || playerctrl.hit_ob == n4 ||
                        playerctrl.hit_ob == n5 || playerctrl.hit_ob == n6 || playerctrl.hit_ob == n7 ||
                        playerctrl.hit_ob == n8 || playerctrl.hit_ob == n9))
                {
                    count++; sp2.SetActive(false);
                }
            }
            else if (count == 2)
            {
                if (playerctrl.hit_ob == n3)
                {
                    count++; correct++; sp3.SetActive(false);
                }
                else if ((playerctrl.hit_ob == n0 || playerctrl.hit_ob == n2 || playerctrl.hit_ob == n4 ||
                        playerctrl.hit_ob == n5 || playerctrl.hit_ob == n6 || playerctrl.hit_ob == n7 ||
                        playerctrl.hit_ob == n8 || playerctrl.hit_ob == n9 || playerctrl.hit_ob == n1))
                {
                    count++; sp3.SetActive(false);
                }
            }
            else if (count == 3)
            {
                if (playerctrl.hit_ob == n7)
                {
                    count++; correct++; sp4.SetActive(false);
                    if (correct == 4)
                    {
                        door1.SetActive(false);
                    }
                    if(correct!=4)
                    {
                        count = 0; correct = 0;
                        sp1.SetActive(true);
                        sp2.SetActive(true);
                        sp3.SetActive(true);
                        sp4.SetActive(true);
                    }
                }
                else if (playerctrl.hit_ob == n2 || playerctrl.hit_ob == n3 || playerctrl.hit_ob == n4 ||
                        playerctrl.hit_ob == n5 || playerctrl.hit_ob == n6 || playerctrl.hit_ob == n0 ||
                        playerctrl.hit_ob == n8 || playerctrl.hit_ob == n9 || playerctrl.hit_ob == n1)
                {
                    count = 0; correct = 0;
                    sp1.SetActive(true);
                    sp2.SetActive(true);
                    sp3.SetActive(true);
                    sp4.SetActive(true);
                }
            }
        }
    }
}
