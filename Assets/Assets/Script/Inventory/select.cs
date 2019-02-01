using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select : MonoBehaviour
{


    public float v1;

    public Image myImage;
    public Sprite mySecondImage;
    public Image noneUsing;
    public static int i = 0;


    public void bigImage()//버튼1을 누르면
    {

        if (imageChange.a == 1)
        { //인벤토리에 ㄷ이 들어 있는 경우에만
            myImage.sprite = mySecondImage;
            noneUsing.sprite = mySecondImage;
            openerselect.i = 0;
            select2.i = 0;
            select3.i = 0;
            select4.i = 0;
            select5.i = 0;
            i = 1;



            //Rotation.i를 이용해 처음으로 되돌리는 작업
            if (Rotation.i1 == 1)
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));


            }
            else if (Rotation.i1 == 2)
            {
                myImage.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));
                noneUsing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));


            }
            else if (Rotation.i1 == 3)
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
