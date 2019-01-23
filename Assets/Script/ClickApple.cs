using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickApple : MonoBehaviour {

    GameObject BoardQuestion;
    GameObject BoardAnswer;

	// Use this for initialization
	void Start () {
        BoardAnswer = GameObject.Find("MagicBoard");
        BoardQuestion = GameObject.Find("MagicQuestion");
        BoardAnswer.SetActive(false);
        BoardQuestion.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        BoardAnswer.SetActive(true);
        BoardQuestion.SetActive(true);
    }
}
