using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSound, sfxSound;
    public AudioSource musicSource, sfxSource;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("MuteMusic", 0) == 1) return;
        playMusic("BgSound");
    }
    public void playMusic(String name)
    {
        if (PlayerPrefs.GetInt("MuteMusic", 0) == 1) return;
        Sound s = Array.Find(musicSound, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void playSFX(String name)
    {
        if (PlayerPrefs.GetInt("MuteSFX", 0) == 1) return;
        Sound s = Array.Find(sfxSound, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource.clip = s.clip;
            sfxSource.Play();
        }
    }

    public void MuteMusic(bool mute = true)
    {
        musicSource.mute = mute;
        PlayerPrefs.SetInt("MuteMusic", (mute) ? 1 : 0);
    }
    public void MuteSFX(bool mute = true)
    {
        sfxSource.mute = mute;
        PlayerPrefs.SetInt("MuteSFX", (mute) ? 1 : 0);
    }
}
