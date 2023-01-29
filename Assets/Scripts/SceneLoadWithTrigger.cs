using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVR;

public class SceneLoadWithTrigger : MonoBehaviour
{
    public int IndexNumForward;
    public int IndexNumBackward;
    float timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            // SecondaryIndexTrigger ������ Ʈ���� ��ư
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
    }
}
