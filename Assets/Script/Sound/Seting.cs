using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seting : MonoBehaviour
{
    [SerializeField] Image m, s;
    [SerializeField] Sprite on, off;
    public void music()
    {
        AudioManager.Instance.MuteMusic((PlayerPrefs.GetInt("MuteMusic", 0) != 1));
    }
    public void sfx()
    {
        AudioManager.Instance.MuteSFX((PlayerPrefs.GetInt("MuteSFX", 0) != 1));
    }
    void Update()
    {
        m.sprite = (PlayerPrefs.GetInt("MuteMusic", 0) == 1) ? off : on;
        s.sprite = (PlayerPrefs.GetInt("MuteSFX", 0) == 1) ? off : on;
    }
}
