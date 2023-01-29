using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBackgroundMusic : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;
    private string scene_name;

    private void Awake()
    {
        BackgroundMusic = GameObject.Find("IntroBgm");
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
        if(scene_name == "OpeningScene06_Bombing" || scene_name == "OpeningScene01")
        {
            backmusic.Stop();
        }
    }
}
