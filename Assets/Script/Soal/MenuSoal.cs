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
    [Header("Image")]
    [SerializeField] public List<Sprite> sRumah = null;
    [SerializeField] public List<Sprite> sBaju = null;
    [SerializeField] public List<Sprite> sTari = null;
    [SerializeField] public List<Sprite> sAlatMusik = null;
    [SerializeField] public List<Sprite> sMakanan = null;

    private static MenuSoal instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Rumah.GetComponent<Button>().onClick.AddListener(delegate { onClick(gRumah); });
        Baju.GetComponent<Button>().onClick.AddListener(delegate { onClick(gBaju); });
        Tari.GetComponent<Button>().onClick.AddListener(delegate { onClick(gTari); });
        AlatMusik.GetComponent<Button>().onClick.AddListener(delegate { onClick(gAlatMusik); });
        Makanan.GetComponent<Button>().onClick.AddListener(delegate { onClick(gMakanan); });
    }

    public static MenuSoal get() { return instance; }

    void onClick(GameObject g)
    {
        DontDestroyOnLoad(g);
        SceneManager.LoadScene("MainSoal");
        AudioManager.Instance.playSFX("ButtonClick");
    }
}
