using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor : MonoBehaviour {
    public GameObject ㄷ1;
    public GameObject ㄴ;
    public GameObject ㅁ;
    public GameObject ㄷ2;
    public GameObject ㅈ;

    float turnspeed = 2f;
    Vector3 V3;
    int speed = 10;

    public Image CursorGageImage;
    // 커서 이미지를 저장하는 변수

    private Vector3 ScreenCenter;
    // 카메라의 중앙 지점을 저장하는 변수

    private float GageTimer;
    // 커서 게이지를 3초간 1까지 증가시키기 위한 변수, 0으로 초기화.

    public bool ClickArise = false;

    // Use this for initialization


    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        // 메인 카메라 화면의 높이/2 = x좌표, 넓이/2 y좌표 = 카메라 중앙 좌표 
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        //카메라 중앙 좌표부터 레이를 생성
        RaycastHit hit;
        //ray가 충돌한 지점의 정보를 저장하는 변수
        CursorGageImage.fillAmount = GageTimer;
        //커서 게이지 이미지의 fillAmount의 값은 GageTimer의 값과 같게 한다.

        if (Physics.Raycast(ray, out hit, 100.0f))
        //ray를 100.0f 거리까지 쏘아서 충돌 상태를 확인한다.
        {
            if (hit.collider.CompareTag("Box"))
            //ray에 hit한 collider의 Tag가 Box일 경우에만
            {
                GageTimer += 1.0f / 3.0f * Time.deltaTime;
                // 3초 동안 GageTimer을 1로 증가시킨다.
                if (GageTimer >= 1)
                //GageTimer이 1이상 이면
                {
                    ClickArise = true;
                    V3 = new Vector3(0, Input.GetAxis("Mouse X"), 0);
                    transform.Rotate(V3 * turnspeed);
                    GageTimer = 0;
                    //입력을 완료했으니 GageTimer를 0으로 한다.
                }

                if (ClickArise)
                    moveObject();
            }
        }
        else
            GageTimer = 0;
        //ray에 아무것도 충돌하지 않으면 GageTimer를 0으로 한다.
    }

    public void moveObject()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        transform.Translate(Vector3.up * speed * Time.smoothDeltaTime * keyVertical, Space.World);
    }

}
