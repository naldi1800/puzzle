using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;


[System.Serializable]
public struct times
{
    public int star1;
    public int star2;
    public int star3;
}


public class TimeEnd : MonoBehaviour
{
    [Header("Time")]
    [SerializeField] bool defaultTime = true;

    // [ShowIf("defaultTime", true)]
    TileSpawn.difficulty difficulty;

    times times;

    // Start is called before the first frame update
    // void Awake()
    // {

    //     times = new times();
    //     if (defaultTime == false)
    //     {

    //     }
    //     if (difficulty == TileSpawn.difficulty.Easy)
    //     {
    //         times.star1 = 120;
    //         times.star2 = 90;
    //         times.star3 = 60;
    //     }
    //     else if (difficulty == TileSpawn.difficulty.Normal)
    //     {
    //         times.star1 = 100;
    //         times.star2 = 70;
    //         times.star3 = 50;
    //     }
    //     else if (difficulty == TileSpawn.difficulty.Hard)
    //     {
    //         times.star1 = 80;
    //         times.star2 = 50;
    //         times.star3 = 30;
    //     }
    //     else if (difficulty == TileSpawn.difficulty.VeryHard)
    //     {
    //         times.star1 = 50;
    //         times.star2 = 35;
    //         times.star3 = 20;
    //     }
    // }

    void Awake()
    {
        int s1 = 120;
        int s2 = 90;
        int s3 = 60;
        if (difficulty == TileSpawn.difficulty.Easy)
        {
            s1 = 120;
            s2 = 90;
            s3 = 60;
        }
        else if (difficulty == TileSpawn.difficulty.Normal)
        {
            s1 = 100;
            s2 = 70;
            s3 = 50;
        }
        else if (difficulty == TileSpawn.difficulty.Hard)
        {
            s1 = 80;
            s2 = 50;
            s3 = 30;
        }
        else if (difficulty == TileSpawn.difficulty.VeryHard)
        {
            s1 = 50;
            s2 = 35;
            s3 = 20;
        }
       times.star1 = s1;
       times.star2 = s2;
       times.star3 = s3;
    }

    public times getTime()
    {
        return this.times;
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(TimeEnd))]
    public class editor : Editor
    {
        TileSpawn.difficulty d = TileSpawn.difficulty.Easy;

        int s1 = 120;
        int s2 = 90;
        int s3 = 60;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            TimeEnd time = (TimeEnd)target;

            EditorGUI.BeginDisabledGroup(!time.defaultTime);
            // time.difficulty = (TileSpawn.difficulty)EditorGUILayout.EnumMaskField("Difficulty", d);
            time.difficulty = (TileSpawn.difficulty)EditorGUILayout.EnumPopup("Difficulty", d);
            d = time.difficulty;

            if (time.difficulty == TileSpawn.difficulty.Easy)
            {
                s1 = 120;
                s2 = 90;
                s3 = 60;
            }
            else if (time.difficulty == TileSpawn.difficulty.Normal)
            {
                s1 = 100;
                s2 = 70;
                s3 = 50;
            }
            else if (time.difficulty == TileSpawn.difficulty.Hard)
            {
                s1 = 80;
                s2 = 50;
                s3 = 30;
            }
            else if (time.difficulty == TileSpawn.difficulty.VeryHard)
            {
                s1 = 50;
                s2 = 35;
                s3 = 20;
            }
            EditorGUI.EndDisabledGroup();
            // time.defaultTime = EditorGUILayout.Foldout(time.defaultTime, "Default Time", false);

            EditorGUI.BeginDisabledGroup(time.defaultTime);
            EditorGUILayout.LabelField("Start in second");
            EditorGUI.indentLevel++;
            time.times.star1 = EditorGUILayout.IntField("Star 1", s1);
            time.times.star2 = EditorGUILayout.IntField("Star 2", s2);
            time.times.star3 = EditorGUILayout.IntField("Star 3", s3);

            s1 = time.times.star1;
            s2 = time.times.star2;
            s3 = time.times.star3;

            EditorGUI.indentLevel--;
            EditorGUI.EndDisabledGroup();
            // Debug.Log(s1);
            // Debug.Log(s2);
            // Debug.Log(s3);
        }

    }
#endif
}