using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public static MenuButtons Instance;
    void Awake()
    {
        if(Instance == null){
            Instance = this;
        }else{
            Debug.Log("Instance Menu Button is found");
        }
    }
    public void endApplication()
    {
        Application.Quit();
    }

    public void moveScene(string scaneName)
    {
        SceneManager.LoadScene(scaneName);
        AudioManager.Instance.playSFX("ButtonClick");
    }
    public void moveSceneAndDestroy(string scaneName)
    {
        // TileSpawn.thisMenu.onMenu();
        // TileSpawn.thisMenu
        GameObject onLoad = GameObject.Find("MainMenu");
        MenuPuzzle instanceMenu = onLoad.GetComponent<MenuPuzzle>();
        Destroy(instanceMenu.gameObject);
        moveScene(scaneName);
    }

    public void moveSceneDestroy(string scaneName)
    {
        GameObject onLoad = null;
        for (int i = 0; i < MenuSoal.sceneName.Count; i++)
        {
            onLoad = GameObject.Find(MenuSoal.sceneName[i]);
            if (onLoad != null) break;
        }
        BankSoal instanceMenu = onLoad.GetComponent<BankSoal>();
        Destroy(instanceMenu.gameObject);
        moveScene(scaneName);
    }
}
