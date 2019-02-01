using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnList : MonoBehaviour {

    public bool[] Clicks;

    private bool[] Correct;

    // Use this for initialization
    void Start () {
        Clicks = new bool[9];
        Correct = new bool[9];
        Correct[0] = Correct[1] = Correct[2] = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool check()
    {
        for (int i = 0; i < 8; i++)
        {
            if (Correct[i] != Clicks[i])
            {
                return false;
            }
        }
        return true;
    }
}
