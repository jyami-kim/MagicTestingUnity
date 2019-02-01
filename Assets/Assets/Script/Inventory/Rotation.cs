using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour {
 
    public Image big;
    public Image usingItem;
    public Image inventoryImage1;
    public static int i1 = 0;

    public Image inventoryImage2;
    public static int i2 = 0;

    public Image inventoryImage3;
    public static int i3 = 0;

    public Image inventoryImage4;
    public static int i4 = 0;

    public Image inventoryImage5;
    public static int i5 = 0;
   
    
    public void rotation()
    {
        
        if (select.i == 1 && Block1.put == 0)  //인벤토리1 선택시&안끼워졌을 때
        { 

            i1++;
            if (i1 == 4)
                i1 = 0;
            big.transform.Rotate(new Vector3(0, 0, 90));
            usingItem.transform.Rotate(new Vector3(0, 0, 90));
            //inventoryImage1.transform.localRotation = Quaternion.Euler(new Vector3(0,0,90.0f));
            inventoryImage1.transform.Rotate(new Vector3(0, 0, 90));
            GameObject.Find("block1").transform.Rotate(new Vector3(0, 0, -90));
        }
        else if (select2.i == 1&&Block3.put==0)
        {
            i2++;
            if (i2 == 4)
                i2 = 0;
            big.transform.Rotate(new Vector3(0, 0, 90));
            usingItem.transform.Rotate(new Vector3(0, 0, 90));
            inventoryImage2.transform.Rotate(new Vector3(0, 0, 90));
            GameObject.Find("block3").transform.Rotate(new Vector3(0, 0, -90));
        }
        else if (select3.i ==1&&Block4.put==0)
        {
            i3++;
            if (i3 == 4)
                i3 = 0;
            big.transform.Rotate(new Vector3(0, 0, 90));
            usingItem.transform.Rotate(new Vector3(0, 0, 90));
            inventoryImage3.transform.Rotate(new Vector3(0, 0, 90));
            GameObject.Find("block4").transform.Rotate(new Vector3(0, 0, -90));
        }
        else if (select4.i ==1&&Block2.put==0)
        {
            i4++;
            if (i4 == 4)
                i4 = 0;
            big.transform.Rotate(new Vector3(0, 0, 90));
            usingItem.transform.Rotate(new Vector3(0, 0, 90));
            inventoryImage4.transform.Rotate(new Vector3(0, 0, 90));
            GameObject.Find("block2").transform.Rotate(new Vector3(0, 0, -90));
        }

        else if (select5.i == 1&&Block5.put==0)
        {
            i5++;
            if (i5 == 4)
                i5 = 0;
            big.transform.Rotate(new Vector3(0, 0, 90));
            usingItem.transform.Rotate(new Vector3(0, 0, 90));
            inventoryImage5.transform.Rotate(new Vector3(0, 0, 90));
            GameObject.Find("block5").transform.Rotate(new Vector3(0, 0, -90));
        }

    }
    
}
