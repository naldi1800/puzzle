using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[System.Serializable]
public class LevelSetting
{

    public TileSpawn.difficulty dif = TileSpawn.difficulty.Easy;
    public string judul;
    [TextArea]
    public string penjelasan;
    

    public Sprite oriImage;
    public Texture2D image;
    // [Header("Fragment Length \nEasy = 12, Normal = 20 \nHard =  30, Very Hard = 56")]
    // [Header("")]
    // public List<Sprite> frag = new List<Sprite>();
    // public bool defaultTime;
    

}