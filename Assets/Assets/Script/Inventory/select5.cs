using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select5 : MonoBehaviour {
    
    public Image myImage;
    public Sprite mySecondImage;
    public Image noneUsing;
    public static int i = 0;

    public void bigImage()
    {
        if (imageChange5.a == 1)
        {
            myImage.sprite = mySecondImage;
            noneUsing.sprite = mySecondImage;
            openerselect.i = 0;
            select.i = 0;
            select2.i = 0;
            select3.i = 0;
            select4.i = 0;
            i = 1;




            if (Rotation.i5 == 1)
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));


            }
            else if (Rotation.i5 == 2)
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));


            }
            else if (Rotation.i5 == 3)
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));

            }
            else
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }


        }
       

    }
}
