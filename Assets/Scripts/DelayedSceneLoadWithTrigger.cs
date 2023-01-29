using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVR;


public class DelayedSceneLoadWithTrigger : MonoBehaviour
{
    public int IndexNumForward;
    public int IndexNumBackward;
    float timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            //Action
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) || Input.GetMouseButtonDown(0))
            {
                //Debug.Log("오른손 트리거 버튼 클릭");
                SceneManager.LoadScene(IndexNumForward);
            }
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) || Input.GetMouseButtonDown(1))
            {
                //Debug.Log("왼쪽 트리거 버튼 클릭");
                SceneManager.LoadScene(IndexNumBackward);
            }
        }
            // SecondaryIndexTrigger 오른손 트리거 버튼
        
    }
}