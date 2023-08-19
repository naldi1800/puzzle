using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private int[] highScore = new int[5];
    private string[] highScoreName = new string[5];
    private string[] highScoreCategory = new string[5];
    private string highScoreKey = "HighScore";
    private string highScoreNameKey = "HighScoreName";
    private string highScoreCategoryKey = "HighScoreCategory";
    public int[] highScoreValue
    {
        get
        {
            return highScore;
        }
        private set
        {
            for (int i = 0; i < 5; i++)
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
            for (int i = 0; i < 5; i++)
            {
                PlayerPrefs.SetString(highScoreNameKey + "-" + i, value[i].ToString());
                highScoreName[i] = value[i];
            }
        }
    }

    public string[] highScoreCategoryValue
    {
        get
        {
            return highScoreCategory;
        }
        private set
        {
            for (int i = 0; i < 5; i++)
            {
                PlayerPrefs.SetString(highScoreCategoryKey + "-" + i, value[i].ToString());
                highScoreCategory[i] = value[i];
            }
        }
    }

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            highScore[i] = PlayerPrefs.GetInt(highScoreKey + "-" + i, 0);
            highScoreName[i] = PlayerPrefs.GetString(highScoreNameKey + "-" + i, "");
            highScoreCategory[i] = PlayerPrefs.GetString(highScoreCategoryKey + "-" + i, "");

        }
    }
    public void setHighScore(string name, string category,int value, int index)
    {
        PlayerPrefs.SetInt(highScoreKey + "-" + index, value);
        highScore[index] = value;
        PlayerPrefs.SetString(highScoreNameKey + "-" + index, name);
        highScoreName[index] = name;
        PlayerPrefs.SetString(highScoreCategoryKey + "-" + index, category);
        highScoreCategory[index] = category;
    }
    public void setHighScore(string[] name, string[] category,  int[] value)
    {
        highScoreValue = value;
        highScoreNameValue = name;
        highScoreCategoryValue = name;

    }
}
