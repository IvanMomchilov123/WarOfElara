using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    public AudioClip songIntro;
    public AudioClip songMainPart;
    public AudioClip songOutro;
    public AudioSource audioSource;
    public MusicState musicState;

    void Start()
    {
        audioSource.playOnAwake = false; 
        audioSource.loop = false; 
        audioSource.volume = 0.2f;
        audioSource.clip = songIntro;
        audioSource.Play();
    }

    void Update()
    {
        if (musicState == MusicState.Intro && !audioSource.isPlaying)
            NextPart();
    }

    public void NextPart()
    {
        switch (musicState)
        {
            case MusicState.Intro:
                audioSource.clip = songMainPart; 
                audioSource.Play();
                musicState = MusicState.MainPart;
                audioSource.loop = true;
                break;
            case MusicState.MainPart:
                audioSource.clip = songOutro;
                audioSource.Play();
                musicState = MusicState.Outro;
                break;
            default:
                break;
        }
    }

    public enum MusicState
    {
        Intro,
        MainPart,
        Outro
    }
}
