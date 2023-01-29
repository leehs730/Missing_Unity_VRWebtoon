using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBackgroundMusic : MonoBehaviour
{
    GameObject BackGroundMusic;
    AudioSource backmusic;
    private string scene_name;


    private void Awake()
    {
        BackGroundMusic = GameObject.Find("MainBgm");
        backmusic = BackGroundMusic.GetComponent<AudioSource>();
        if (backmusic.isPlaying) return;
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(BackGroundMusic);
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
        if (scene_name == "OpeningScene08" || scene_name == "SpaceScene29")
        {
            backmusic.Stop();
        }
    }
}
