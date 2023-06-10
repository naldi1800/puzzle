using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSoal : MonoBehaviour
{
    [SerializeField] Button Rumah;
    [SerializeField] Button Baju;
    [SerializeField] Button Tari;
    [SerializeField] Button AlatMusik;
    [SerializeField] Button Makanan;
    [SerializeField]
    public static List<string> sceneName = new List<string>(){
        "RumahAdat",
        "BajuAdat",
        "TariAdat",
        "AlatMusikTradisional",
        "MakananTradisional",
    };
    [SerializeField] GameObject gRumah;
    [SerializeField] GameObject gBaju;
    [SerializeField] GameObject gTari;
    [SerializeField] GameObject gAlatMusik;
    [SerializeField] GameObject gMakanan;

    void Awake()
    {
        Rumah.GetComponent<Button>().onClick.AddListener(delegate { onClick(gRumah); });
        Baju.GetComponent<Button>().onClick.AddListener(delegate { onClick(gBaju); });
        Tari.GetComponent<Button>().onClick.AddListener(delegate { onClick(gTari); });
        AlatMusik.GetComponent<Button>().onClick.AddListener(delegate { onClick(gAlatMusik); });
        Makanan.GetComponent<Button>().onClick.AddListener(delegate { onClick(gMakanan); });
    }

    void onClick(GameObject g)
    {
        DontDestroyOnLoad(g);
        SceneManager.LoadScene("MainSoal");
    }
}
