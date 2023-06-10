using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void moveScene(string scaneName){
        SceneManager.LoadScene(scaneName);
    }   
}
