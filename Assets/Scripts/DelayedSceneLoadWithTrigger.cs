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
                //Debug.Log("������ Ʈ���� ��ư Ŭ��");
                SceneManager.LoadScene(IndexNumForward);
            }
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) || Input.GetMouseButtonDown(1))
            {
                //Debug.Log("���� Ʈ���� ��ư Ŭ��");
                SceneManager.LoadScene(IndexNumBackward);
            }
        }
            // SecondaryIndexTrigger ������ Ʈ���� ��ư
        
    }
}