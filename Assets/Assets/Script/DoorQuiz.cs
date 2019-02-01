using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//답: 1010
public class DoorQuiz : MonoBehaviour {

    private PlayerControl playerctrl;
    public GameObject sp1, sp2, sp3, sp4;
    public GameObject door1;
    int count = 0, correct = 0;
    public GameObject n0, n1;
    //int a = 0, b = 0, c = 0, d = 0;

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
            if (count == 0)
            {
                if (playerctrl.hit_ob == n1)
                {
                    count++; correct++; sp1.SetActive(false);
                }
                else if (playerctrl.hit_ob == n0)
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
                else if (playerctrl.hit_ob == n1)
                {
                    count++; sp2.SetActive(false);
                }
            }
            else if (count == 2)
            {
                if (playerctrl.hit_ob == n1)
                {
                    count++; correct++; sp3.SetActive(false);
                }
                else if (playerctrl.hit_ob == n0)
                {
                    count++; sp3.SetActive(false);
                }
            }
            else if (count == 3)
            {
                if (playerctrl.hit_ob == n0)
                {
                    count++; correct++; sp4.SetActive(false);
                    if (correct == 4)
                    {
                        door1.SetActive(false);
                    }
                    else
                    {
                        count = 0; correct = 0;
                        sp1.SetActive(true);
                        sp2.SetActive(true);
                        sp3.SetActive(true);
                        sp4.SetActive(true);
                    }
                }
                else if (correct != 4)
                {
                    count = 0; correct = 0;
                    sp1.SetActive(true);
                    sp2.SetActive(true);
                    sp3.SetActive(true);
                    sp4.SetActive(true);
                }
            }

            //    if (playerctrl.hit_ob==n0)
            //    {
            //        a++; c++;
            //    }
            //    else if (playerctrl.hit_ob.CompareTag("1"))
            //    {
            //        a++; b++;
            //    }
            //    if (a == 1)
            //    {
            //        sp1.SetActive(false);
            //        if (b == 1 && c == 0)
            //        {
            //            d++;
            //        }
            //    }

            //    else if (a == 2)
            //    {
            //        sp2.SetActive(false);
            //        if (c == 1 && b == 1)
            //        {
            //            d++;
            //        }
            //    }
            //    else if (a == 3)
            //    {
            //        sp3.SetActive(false);
            //        if (b == 2 && c == 1)
            //        {
            //            d++;
            //        }
            //    }

            //    else if (a == 4)
            //    {
            //        sp4.SetActive(false);
            //        if (c == 2 && b == 2)
            //        {
            //            d++;
            //        }
            //        if (d == 4)
            //        {
            //            door1.SetActive(false);
            //            d = 0;
            //        }
            //        else
            //        {
            //            sp1.SetActive(true);
            //            sp2.SetActive(true);
            //            sp3.SetActive(true);
            //            sp4.SetActive(true);
            //        }
            //        a = 0; b = 0; c = 0; d = 0;
            //    }
            //}
        }
    }
}
