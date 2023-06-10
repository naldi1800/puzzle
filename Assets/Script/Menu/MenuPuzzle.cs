using System.Text.RegularExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuPuzzle : MonoBehaviour
{
    public int numberOfLevel = 0;
    public List<MainLevel> mainLevels = new List<MainLevel>();
    private static MenuPuzzle instance;
    public GameObject main;
    public List<GameObject> buttons;
    public int activeLevel = 0;


    public static MenuPuzzle get
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            onLoad();
            DontDestroyOnLoad(gameObject);
            return;
        }
        Debug.Log("Another Instance is Found");
    }

    void onLoad()
    {
        if (main == null)
        {
            Debug.Log("Main menu is null");
            return;
        }
        buttons = new List<GameObject>();
        for (int i = 0; i < main.transform.childCount; i++)
        {
            buttons.Add(main.transform.GetChild(i).gameObject);
        }

        foreach (GameObject i in buttons)
        {
            Button b = i.AddComponent<Button>();
            b.onClick.AddListener(() => bClick(i));
            b.transition = Selectable.Transition.None;
        }
    }
    void bClick(GameObject gm)
    {
        String name = gm.name;
        int level = int.Parse(Regex.Replace(name, @"\D", ""));
        Debug.Log(level);
        activeLevel = level;
        MainLevel m = mainLevels[level - 1];
        // Debug.Log(JsonUtility.ToJson(m));
        SceneManager.LoadScene("MainGame");

    }
}



#if UNITY_EDITOR
[CustomEditor(typeof(MenuPuzzle))]
class editor : Editor
{
    public override void OnInspectorGUI()
    {
        // base.OnInspectorGUI();


        var puzzle = (MenuPuzzle)target;
        if (puzzle == null) return;
        Undo.RecordObject(puzzle, "Change");

        GUILayout.Label("Jumlah Level");
        GUILayout.BeginHorizontal();
        EditorGUI.BeginDisabledGroup(true);
        puzzle.numberOfLevel = EditorGUILayout.IntField(puzzle.numberOfLevel);
        EditorGUI.EndDisabledGroup();
        EditorGUI.BeginDisabledGroup(puzzle.numberOfLevel == 0);
        if (GUILayout.Button("-"))
        {
            if (puzzle.numberOfLevel > 0)
            {
                puzzle.numberOfLevel -= 1;
            }
            else
            {
                puzzle.numberOfLevel = 0;
            }
        }
        EditorGUI.EndDisabledGroup();
        if (GUILayout.Button("+"))
        {
            puzzle.numberOfLevel += 1;
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(15);
        GUILayout.Label("Button Menu");
        puzzle.main = EditorGUILayout.ObjectField(puzzle.main, typeof(GameObject), true) as GameObject;
        GUILayout.Label("Current Level");
        puzzle.activeLevel = EditorGUILayout.IntField(puzzle.activeLevel);
        
        GUILayout.Space(15);
        if (puzzle.numberOfLevel > puzzle.mainLevels.Count)
        {
            puzzle.mainLevels.Add(new MainLevel());
            // puzzle.mainLevels.Add(null);
        }
        if (puzzle.numberOfLevel < puzzle.mainLevels.Count)
        {
            // mainLevels.RemoveAt(mainLevels.Count - 1);
            puzzle.mainLevels.RemoveAt(puzzle.mainLevels.Count - 1);
        }
        for (int i = 0; i < puzzle.mainLevels.Count; i++)
        {
            GUILayout.Label("Level " + (i + 1));
            puzzle.mainLevels[i].level = i + 1;
            puzzle.mainLevels[i] = EditorGUILayout.ObjectField(puzzle.mainLevels[i], typeof(MainLevel), true) as MainLevel;
            GUILayout.Space(10);
        }


    }

}
#endif
