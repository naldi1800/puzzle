using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainSoal : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI soal;
    [SerializeField] TextMeshProUGUI[] jawaban;
    [SerializeField] TextMeshProUGUI scoreGame;

    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject finish;

    [SerializeField] private GameObject soalOnly;
    [SerializeField] private GameObject soalAndImage;
    [SerializeField] private bool isImageSoal = false;
    public int score = 0;
    private string isAnswer;
    private static BankSoal instanceMenu;
    public static MainSoal ints;
    private bool buttonClicked = false;
    private bool isFinish = false;
    List<int> lcm = new List<int>();
    void Awake()
    {
        if (ints == null) { ints = this; }
        if (instanceMenu == null)
        {
            lcm.AddRange(LCM(Random.Range(1, 50)));
            GameObject onLoad = null;
            for (int i = 0; i < MenuSoal.sceneName.Count; i++)
            {
                onLoad = GameObject.Find(MenuSoal.sceneName[i]);
                if (onLoad != null) break;
            }
            instanceMenu = onLoad.GetComponent<BankSoal>();
            Soal s = instanceMenu.bankSoal[lcm[instanceMenu.activeLevel]];
            set(s);
        }
        else
        {
            Debug.Log("Another Instance is Found");
        }
    }

    void Start()
    {
        onResume();
    }

    void set(Soal s)
    {
        soal.text = s.soal;
        List<int> pilihan = new List<int> { 0, 1, 2, 3 };
        for (int i = 0; i < s.pilihan.Length; i++)
        {
            int r = Random.Range(0, pilihan.Count - 1);
            jawaban[i].text = s.pilihan[pilihan[r]];
            pilihan.RemoveAt(r);
        }
        isAnswer = s.answer;
        isImageSoal = s.image != null;
        if (isImageSoal)
        {
            soalAndImage.SetActive(true);
            soalOnly.SetActive(false);
        }
        else
        {
            soalAndImage.SetActive(false);
            soalOnly.SetActive(true);
        }
        setButton();
    }


    void setButton()
    {
        for (int i = 0; i < jawaban.Length; i++)
        {
            int iLocal = i;
            Button b = jawaban[i].gameObject.transform.parent.gameObject.GetComponent<Button>();
            b.onClick.AddListener(delegate
            {
                if (!buttonClicked)
                {
                    buttonClicked = true;
                    validate(jawaban[iLocal].text);
                    StartCoroutine(wait());
                }
            });
        }
    }

    void validate(string text)
    {
        if (text == isAnswer)
        {
            score += 10;
            Debug.Log("Is True Score");
        }
        else Debug.Log("Is False");

        if (instanceMenu.activeLevel >= 9)
        {
            Debug.Log("Game Finish : " + score);
            onFinish();
            return;
        }

        instanceMenu.activeLevel += 1;
        Soal s = instanceMenu.bankSoal[lcm[instanceMenu.activeLevel]];
        set(s);

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        buttonClicked = false;
    }

    List<int> LCM(int packet)
    {
        if (packet % 10 == 0) packet -= 1;
        int a = 1;
        int c = 3;
        int m = 50;
        List<int> result = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            int x = (packet * a + c) % m;
            result.Add(x);
            packet = x;
        }
        return result;
    }


    public void onPause()
    {
        game.SetActive(false);
        pause.SetActive(true);
        finish.SetActive(false);
    }

    public void onResume()
    {
        game.SetActive(true);
        pause.SetActive(false);
        finish.SetActive(false);
    }
    void onFinish()
    {
        pause.SetActive(false);
        game.SetActive(false);
        finish.SetActive(true);
        scoreGame.text = "SCORE \n" + score;
    }

    public void onSoundSet()
    {
        Debug.Log("Sound is click");
    }
    public void onBack()
    {
        Debug.Log("Back is click");
    }
    public void onMenu()
    {
        Destroy(instanceMenu.gameObject);
    }
}
