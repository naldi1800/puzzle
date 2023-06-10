using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
// [System.Serializable]
public class Soal : ScriptableObject
{
    public int idSoal;
    public TypeSoal typeSoal;
    [TextArea]
    public string soal;
    public string answer;
    public string[] pilihan = new string[4];
    public Sprite image;

    public enum TypeSoal {RumahAdat, BajuAdat, AlatMusikTradisional, MakananTradisional, TariAdatTradisional};

    public Soal(TypeSoal typeSoal){
        this.typeSoal = typeSoal;
    }
}