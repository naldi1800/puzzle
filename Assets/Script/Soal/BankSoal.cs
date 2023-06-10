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
    public static BankSoal instance;
    // public GameObject main;
    // public List<GameObject> buttons;
    public int activeLevel = 0;
    public Soal.TypeSoal typeSoal;

    void Awake()
    {
        switch (this.gameObject.name)
        {
            case "Rumah Adat":
                {
                    typeSoal = Soal.TypeSoal.RumahAdat;
                }
                break;
            case "Tari Tradisional":
                {
                    typeSoal = Soal.TypeSoal.TariAdatTradisional;
                }
                break;
            case "Alat Musik":
                {
                    typeSoal = Soal.TypeSoal.AlatMusikTradisional;
                }
                break;
            case "Makanan Tradisional":
                {
                    typeSoal = Soal.TypeSoal.MakananTradisional;
                }
                break;
            case "Baju Adat":
                {
                    typeSoal = Soal.TypeSoal.BajuAdat;
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
        for (int i = 0; i < soal.bankSoal.Count; i++)
        {
            GUILayout.Label("Soal  No " + (i + 1));
            soal.bankSoal[i].idSoal = i + 1;
            soal.bankSoal[i] = EditorGUILayout.ObjectField(soal.bankSoal[i], typeof(Soal), true) as Soal;
            soal.bankSoal[i].soal = "Soal No " + (i + 1);
            soal.bankSoal[i].pilihan[0] = "Pilihan 1";
            soal.bankSoal[i].pilihan[1] = "Pilihan 2";
            soal.bankSoal[i].pilihan[2] = "Pilihan 3";
            soal.bankSoal[i].pilihan[3] = "Pilihan 4";
            soal.bankSoal[i].answer = "Pilihan 1";
            GUILayout.Space(10);
        }


    }

}
#endif
