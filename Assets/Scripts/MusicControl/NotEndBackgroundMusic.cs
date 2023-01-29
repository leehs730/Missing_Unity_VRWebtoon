using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotEndBackgroundMusic : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;
    private string scene_name;
    public double fadeoutSeconds = 1.0;
    bool isFadeOut = true;
    double fadeDeltaTime = 0;

    private void Awake()
    {
        BackgroundMusic = GameObject.Find("NotEndBgm");
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
        if (scene_name == "SpaceScene37" || scene_name == "SpaceScene41")
        {
            backmusic.Stop();
        }

        else if(scene_name == "SpaceScene40")
        {
            if (isFadeOut)
            {
                fadeDeltaTime += Time.deltaTime;
                if (fadeDeltaTime >= fadeoutSeconds)
                {
                    fadeDeltaTime = fadeoutSeconds;
                    isFadeOut = false;
                }
                backmusic.volume = (float)(0.1 - (fadeDeltaTime / fadeoutSeconds)/10);
            }
        }

        
    }
}