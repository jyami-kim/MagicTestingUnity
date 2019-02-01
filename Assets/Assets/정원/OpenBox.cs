using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour {
    
    public GameObject box;
    public static int open=0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
       
        if (Rotation.i1==0 && Rotation.i3==0 && Rotation.i4==0 && Rotation.i5==1 
           &&Block1.i+Block2.i+Block3.i+Block4.i+Block5.i==5 )
        {
            Quaternion v3Rotation = Quaternion.identity;
            v3Rotation.eulerAngles = new Vector3(90f, 0f, 0f);
            Vector3 v3Direction = Vector3.left;
            Vector3 v3RotatedDirection = v3Rotation * v3Direction;
            transform.rotation = Quaternion.Slerp(transform.rotation, v3Rotation, Time.deltaTime * 2.0f);
            open++;
        } 
	}

}
