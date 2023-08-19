using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreView : MonoBehaviour
{
    private string highScoreKey = "HighScore";
    private string highScoreNameKey = "HighScoreName";
    private string highScoreCategoryKey = "HighScoreCategory";

    // Start is called before the first frame update
    void Start()
    {
        HighScore h = GetComponent<HighScore>();
        int items = gameObject.transform.childCount;
        for (int i = 0; i < items; i++)
        {
            GameObject n = gameObject.transform.GetChild(i).gameObject;
            int item = n.transform.childCount;
            TextMeshProUGUI nama,
                kat,
                score;
            nama = n.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
            kat = n.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
            score = n.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>();
            if (PlayerPrefs.GetInt(highScoreKey + "-" + i) != 0)
            {
                nama.text = PlayerPrefs.GetString(highScoreNameKey + "-" + i);
                kat.text = PlayerPrefs.GetString(highScoreCategoryKey + "-" + i);
                score.text = PlayerPrefs.GetInt(highScoreKey + "-" + i) + "";
            }
            else
            {
                nama.text = "-";
                kat.text = "-";
                score.text = "-";
            }

        }
    }
}
