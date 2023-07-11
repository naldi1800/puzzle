using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class BankSoal : MonoBehaviour
{
    public List<Soal> bankSoal = new List<Soal>();
    public int numberOfLevel = 0;
    public int numberOfList = 0;
    public static BankSoal instance;
    // public GameObject main;
    // public List<GameObject> buttons;
    public int activeLevel = 0;
    public List<Sprite> listSprite = new List<Sprite>();


    public Soal.TypeSoal typeSoal;
    void Awake()
    {
        return;
                switch (this.gameObject.name)
        {
            case "RumahAdat":
                {
                    listSprite = MenuSoal.get().sRumah;
                }
                break;
            case "TariAdat":
                {
                    listSprite = MenuSoal.get().sTari;
                }
                break;
            case "AlatMusikTradisional":
                {
                    listSprite = MenuSoal.get().sAlatMusik;
                }
                break;
            case "MakananTradisional":
                {
                    listSprite = MenuSoal.get().sMakanan;
                }
                break;
            case "BajuAdat":
                {
                    listSprite = MenuSoal.get().sBaju;
                }
                break;
        }
    }
}



#if UNITY_EDITOR
[CustomEditor(typeof(BankSoal))]
class editorBankSoal : Editor
{
    public override void OnInspectorGUI()
    {
        // base.OnInspectorGUI();
        var soal = (BankSoal)target;
        if (soal == null) return;
        Undo.RecordObject(soal, "Change");

        GUILayout.Label("Jumlah Item");
        GUILayout.BeginHorizontal();
        EditorGUI.BeginDisabledGroup(true);
        soal.numberOfList = EditorGUILayout.IntField(soal.numberOfList);
        EditorGUI.EndDisabledGroup();
        EditorGUI.BeginDisabledGroup(soal.numberOfList == 0);
        if (GUILayout.Button("-"))
        {
            if (soal.numberOfList > 0)
            {
                soal.numberOfList -= 1;
            }
            else
            {
                soal.numberOfList = 0;
            }
        }
        EditorGUI.EndDisabledGroup();
        if (GUILayout.Button("+"))
        {
            soal.numberOfList += 1;
        }
        GUILayout.EndHorizontal();

        if (soal.numberOfList > soal.listSprite.Count)
        {
            soal.listSprite.Add(null);
        }
        if (soal.numberOfList < soal.listSprite.Count)
        {
            soal.listSprite.RemoveAt(soal.listSprite.Count - 1);
        }

        GUILayout.Label("LIST Image");
        for (int i = 0; i < soal.listSprite.Count; i++)
        {
            soal.listSprite[i] = EditorGUILayout.ObjectField(soal.listSprite[i], typeof(Sprite), true) as Sprite;
            GUILayout.Space(5);

        }


        MenuSoal menu = MenuSoal.get();
        // Debug.Log(menu);
        switch (soal.gameObject.name)
        {
            case "RumahAdat":
                {
                    soal.typeSoal = Soal.TypeSoal.RumahAdat;
                }
                break;
            case "TariAdat":
                {
                    soal.typeSoal = Soal.TypeSoal.TariAdatTradisional;
                }
                break;
            case "AlatMusikTradisional":
                {

                    soal.typeSoal = Soal.TypeSoal.AlatMusikTradisional;
                }
                break;
            case "MakananTradisional":
                {
                    soal.typeSoal = Soal.TypeSoal.MakananTradisional;
                }
                break;
            case "BajuAdat":
                {
                    soal.typeSoal = Soal.TypeSoal.BajuAdat;
                }
                break;
        }

        GUILayout.Label("Current Level");
        soal.activeLevel = EditorGUILayout.IntField(soal.activeLevel);
        GUILayout.Space(15);
        GUILayout.Label("Jumlah Level");
        GUILayout.BeginHorizontal();
        EditorGUI.BeginDisabledGroup(true);
        soal.numberOfLevel = EditorGUILayout.IntField(soal.numberOfLevel);
        EditorGUI.EndDisabledGroup();
        EditorGUI.BeginDisabledGroup(soal.numberOfLevel == 0);
        if (GUILayout.Button("-"))
        {
            if (soal.numberOfLevel > 0)
            {
                soal.numberOfLevel -= 1;
            }
            else
            {
                soal.numberOfLevel = 0;
            }
        }
        EditorGUI.EndDisabledGroup();
        if (GUILayout.Button("+"))
        {
            soal.numberOfLevel += 1;
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(15);
        if (soal.numberOfLevel > soal.bankSoal.Count)
        {
            soal.bankSoal.Add(new Soal(soal.typeSoal));
        }
        if (soal.numberOfLevel < soal.bankSoal.Count)
        {
            soal.bankSoal.RemoveAt(soal.bankSoal.Count - 1);
        }
        Debug.Log(soal.listSprite.Count);
        AllSoal s = new AllSoal();
        List<Dictionary<string, dynamic>> listData = s.get(soal.typeSoal);
        for (int i = 0; i < soal.bankSoal.Count; i++)
        {
            Dictionary<string, dynamic> data = listData[i];
            GUILayout.Label("Soal  No " + (i + 1));
            soal.bankSoal[i].idSoal = i + 1;
            soal.bankSoal[i] = EditorGUILayout.ObjectField(soal.bankSoal[i], typeof(Soal), true) as Soal;
            // soal.bankSoal[i].soal = data["quiz"] as String;
            // soal.bankSoal[i].pilihan[0] = data["p1"] as String;
            // soal.bankSoal[i].pilihan[1] = data["p2"] as String;
            // soal.bankSoal[i].pilihan[2] = data["p3"] as String;
            // soal.bankSoal[i].pilihan[3] = data["p4"] as String;
            // soal.bankSoal[i].answer = data["answer"] as String;
            // var image = data["image"] as String;
            // if (image == "true")
            // {
            //     soal.bankSoal[i].image = soal.listSprite[0];
            //     soal.listSprite.RemoveAt(0);
            // }
            // soal.bankSoal[i].typeSoal = soal.typeSoal;
            GUILayout.Space(10);
        }
    }
}
#endif
