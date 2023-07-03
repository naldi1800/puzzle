using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private int[] highScore = new int[10];
    private string[] highScoreName = new string[10];
    private string highScoreKey = "HighScore";
    private string highScoreNameKey = "HighScoreName";
    public int[] highScoreValue
    {
        get
        {
            return highScore;
        }
        private set
        {
            for (int i = 0; i < 10; i++)
            {
                PlayerPrefs.SetInt(highScoreKey + "-" + i, value[i]);
                highScore[i] = value[i];
            }
        }
    }
    public string[] highScoreNameValue
    {
        get
        {
            return highScoreName;
        }
        private set
        {
            for (int i = 0; i < 10; i++)
            {
                PlayerPrefs.SetString(highScoreNameKey + "-" + i, value[i].ToString());
                highScoreName[i] = value[i];
            }
        }
    }

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            highScore[i] = PlayerPrefs.GetInt(highScoreKey + "-" + i, 0);
            highScoreName[i] = PlayerPrefs.GetString(highScoreNameKey + "-" + i, "");
        }
    }
    public void setHighScore(string name, int value, int index)
    {
        PlayerPrefs.SetInt(highScoreKey + "-" + index, value);
        highScore[index] = value;
        PlayerPrefs.SetString(highScoreNameKey + "-" + index, name);
        highScoreName[index] = name;
    }
    public void setHighScore(string[] name, int[] value)
    {
        highScoreValue = value;
        highScoreNameValue = name;
    }
}
