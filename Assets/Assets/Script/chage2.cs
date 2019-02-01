using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chage2 : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene("level1");
        }
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("way");
        }
    }
}
