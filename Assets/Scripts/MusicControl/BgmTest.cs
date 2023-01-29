using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmTest : MonoBehaviour
{
    private string scene_name;
    public AudioClip[] audios;
    public AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        scene_name = SceneManager.GetActiveScene().name;
        Debug.Log(scene_name);
        Debug.Log(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        audio_source.Play();
        if (scene_name == "SpaceScene09")
        {
            audio_source.clip = audios[0];

        }
        else if (scene_name == "SpaceScene28")
        {
            audio_source.clip = audios[1];

        }
        else if (scene_name == "SpaceScene36")
        {
            audio_source.clip = audios[2];

        }

        else if (scene_name == "SpaceScene40")
        {
            audio_source.clip = audios[3];

        }

    }
}

