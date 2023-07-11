using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreView : MonoBehaviour
{

    private string highScoreKey = "HighScore";
    private string highScoreNameKey = "HighScoreName";
    // Start is called before the first frame update
    void Start()
    {
        HighScore h = GetComponent<HighScore>();
        int cl = gameObject.transform.childCount;
        for (int i = 0; i < cl; i++)
        {
            GameObject n = gameObject.transform.GetChild(i).gameObject;
            TextMeshProUGUI text = n.GetComponent<TextMeshProUGUI>();
            if (PlayerPrefs.GetInt(highScoreKey + "-" + i) != 0)
            {
                text.text = (i + 1) + " " + PlayerPrefs.GetString(highScoreNameKey + "-" + i) + " - " + PlayerPrefs.GetInt(highScoreKey + "-" + i);
            }
            else
            {
                text.text = "-";
            }
        }
    }
}
