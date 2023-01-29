using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmControlFadeOut : MonoBehaviour
{
    private AudioSource audioSource;
    public double fadeoutSeconds = 1.0;
    bool isFadeOut = true;
    double fadeDeltaTime = 0;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        //DontDestroyOnLoad(audioSource);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeOut)
        {
            fadeDeltaTime += Time.deltaTime;
            if (fadeDeltaTime >= fadeoutSeconds)
            {
                fadeDeltaTime = fadeoutSeconds;
                isFadeOut = false;
            }
            audioSource.volume = (float)(1.0 - (fadeDeltaTime / fadeoutSeconds));
        }
    }
}