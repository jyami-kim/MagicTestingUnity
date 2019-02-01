using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintCtrl : MonoBehaviour {

    InputSave inputsave;
    public Sprite color_d;
    public Sprite color_r;
    public Sprite color_g;
    public Sprite color_b;
    public Sprite color_rg;
    public Sprite color_gb;
    public Sprite color_rb;
    private Image outimg;
    

    // Use this for initialization
    void Start () {
        inputsave = GameObject.Find("Input").GetComponent<InputSave>();

        outimg = GetComponent<Image>();
        outimg.sprite  = color_d;
    }

// Update is called once per frame
void Update () {//blue red green 순서

        if (inputsave.save_color[0] && inputsave.save_color[1] && inputsave.save_color[2])
            outimg.sprite = color_d;
        else {
            if (inputsave.save_color[0] && inputsave.save_color[1]) //br
                outimg.sprite = color_rb;
            else if (inputsave.save_color[2] && inputsave.save_color[1]) //gr
                outimg.sprite = color_rg;
            else if (inputsave.save_color[0] && inputsave.save_color[2]) //bg
                outimg.sprite = color_gb;
            else {
                if (inputsave.save_color[0]) //b
                    outimg.sprite = color_b;
                else if (inputsave.save_color[1]) //r
                    outimg.sprite = color_r;
                else if (inputsave.save_color[2]) //g
                    outimg.sprite = color_g;
                else
                    outimg.sprite = color_d;
            }
        }
	}
}
