using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class text : MonoBehaviour {

    Text flashingText;

	// Use this for initialization
	void Start () {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
		
	}
	
	// Update is called once per frame
	public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "내 소지품이 없어졌어!";
            yield return new WaitForSeconds(.5f);
        }
    }
}
