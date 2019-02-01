using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openerselect : MonoBehaviour {

    public static int i=0;
    public Image myImage;
    public Sprite mySecondImage;
    public Image noneUsing;

    public void bigImage()
    {
        if (openerImageChange.a == 1)
        {
            myImage.sprite = mySecondImage;
            noneUsing.sprite = mySecondImage;
            i = 1;
            select.i = 0;
            select2.i = 0;
            select3.i = 0;
            select4.i = 0;
            select5.i = 0;
            myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
        
    }
}
