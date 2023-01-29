using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBackgroundMusic : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;
    private string scene_name;

    private void Awake()
    {
        BackgroundMusic = GameObject.Find("FinalBgm");
        backmusic = BackgroundMusic.GetComponent<AudioSource>();
        if (backmusic.isPlaying) return;
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scene_name = SceneManager.GetActiveScene().name;
        if (scene_name == "SpaceScene41" || scene_name == "SpaceScene44_end")
        {
            backmusic.Stop();
        }
    }
}