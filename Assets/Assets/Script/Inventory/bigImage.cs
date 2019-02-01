using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigImage : MonoBehaviour {

	void Start () {
		
	}
	void Update () {
        if (select.i > 0)
        {
            if (Rotation.i1 == 1)
                transform.Rotate(new Vector3(0, 0, 90));
            else if (Rotation.i1 == 2)
                transform.Rotate(new Vector3(0, 0, 180));
            else if (Rotation.i1 == 3)
                transform.Rotate(new Vector3(0, 0, 270));
            else
                transform.Rotate(new Vector3(0, 0, 0));
        }

    }
}
