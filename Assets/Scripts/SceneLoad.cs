using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OVR;

public class SceneLoad : MonoBehaviour
{
    public void OnClickSceneLoad()
    {
        SceneManager.LoadScene(1);
    }
}
