// using System.Diagnostics;
using System;
using System.Linq;
// using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

#region  secondaryClass
[System.Serializable]
public struct LevelTileAttr
{
    public float x;
    public float y;
    public int length;
}

[System.Serializable]
public class Level
{
    public TileSpawn.difficulty difficulty;
    public LevelTileAttr levelAttr;

    public Level(TileSpawn.difficulty difficulty, LevelTileAttr levelTileAttr)
    {
        this.difficulty = difficulty;
        this.levelAttr = levelTileAttr;
    }
}

#endregion
public class TileSpawn : MonoBehaviour
{
    public enum difficulty { Easy, Normal, Hard, VeryHard };

    [Header("Canvas")]
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject mainGame;
    [SerializeField] private GameObject pauseCanvas;


    [Header("Image")]
    // x: 975 ,  y: 750
    [SerializeField] private Sprite ori;
    [SerializeField] private Sprite[] frag;
    [SerializeField] private Sprite starOf;
    [SerializeField] private Sprite starOn;
    [SerializeField] private Texture2D originalImage;
    List<Sprite> fragOriginal = new List<Sprite>();

    [Header("Difficulty")]
    [SerializeField] private difficulty level;
    [SerializeField] private Level[] levelSetting;

    [Header("Main Game Object")]
    [SerializeField] private GameObject tilesFather;
    [SerializeField] private GameObject tilesSpawnPos;
    [SerializeField] private Image preview;
    [SerializeField] private Image previewFinish;
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private TextMeshProUGUI timeGameObject;
    [SerializeField] private GameObject finishGameObject;
    [SerializeField] private GameObject gameOverGameObject;
    [SerializeField] private TextMeshProUGUI star1;
    [SerializeField] private TextMeshProUGUI star2;
    [SerializeField] private TextMeshProUGUI star3;
    [SerializeField] private TextMeshProUGUI judul;
    [SerializeField] private TextMeshProUGUI penjelasan;
    [SerializeField] private Image starSprite1;
    [SerializeField] private Image starSprite2;
    [SerializeField] private Image starSprite3;

    [SerializeField] private Image pauseStarSprite1;
    [SerializeField] private Image pauseStarSprite2;
    [SerializeField] private Image pauseStarSprite3;

    [SerializeField] private Image gameOverStarSprite1;
    [SerializeField] private Image gameOverStarSprite2;
    [SerializeField] private Image gameOverStarSprite3;

    [SerializeField] private TextMeshProUGUI award;


    [Header("Game Setting")]
    [SerializeField] private int s1;
    [SerializeField] private int s2;
    [SerializeField] private int s3;
    private Vector2 sel;

    private GameObject tileTemplate;
    private LevelTileAttr levelAttr;
    private GameObject[] fragmentObject;

    private float time = 0f;
    private bool isFinish = false;
    private bool isGameOver = false;
    private bool isPause = false;

    private static MenuPuzzle instanceMenu;
    public static TileSpawn thisMenu;


    public void set(MainLevel m)
    {
        level = m.levelSetting.dif;
        ori = m.levelSetting.oriImage;
        preview.sprite = ori;
        previewFinish.sprite = ori;
        originalImage = m.levelSetting.image;
        judul.text = m.levelSetting.judul;
        penjelasan.text = m.levelSetting.penjelasan;
    }
    public void onPause()
    {
        isPause = !isPause;
    }

    public void onMenu()
    {
        Destroy(instanceMenu.gameObject);
        // SceneManager.LoadScene("MenuUtama");
    }
    public void onRestart()
    {
        time = 0f;
        isPause = false;
        isFinish = false;
        isGameOver = false;

        for (int c = 0; c < tilesSpawnPos.transform.childCount; c++)
        {
            Destroy(tilesSpawnPos.transform.GetChild(c).gameObject);
        }

        for (int c = 0; c < tilesFather.transform.childCount; c++)
        {
            Destroy(tilesFather.transform.GetChild(c).gameObject);
        }
        onStart();
    }

    public void onNext()
    {
        onRestart();
        instanceMenu.activeLevel++;
        MainLevel m = instanceMenu.mainLevels[instanceMenu.activeLevel - 1];
        set(m);
    }

    #region  main
    void Awake()
    {
        if (instanceMenu == null)
        {
            GameObject onLoad = GameObject.Find("MainMenu");
            instanceMenu = onLoad.GetComponent<MenuPuzzle>();
            MainLevel m = instanceMenu.mainLevels[instanceMenu.activeLevel - 1];
            set(m);
        }
        else
        {
            Debug.Log("Another Instance is Found");
        }
        
        if(thisMenu == null){
            thisMenu = this;
        }


        settingGame();
        // x: 975 ,  y: 750
        levelSetting = new Level[Enum.GetNames(typeof(difficulty)).Length];
        Vector3[] xy = new Vector3[Enum.GetNames(typeof(difficulty)).Length];
        xy[0] = new Vector3(4, 3, 4 * 3);
        xy[1] = new Vector3(5, 4, 5 * 4);
        xy[2] = new Vector3(6, 5, 6 * 5);
        xy[3] = new Vector3(8, 7, 8 * 7);

        for (int i = 0; i < Enum.GetNames(typeof(difficulty)).Length; i++)
        {
            // Debug.Log("ADA");
            difficulty d = (difficulty)Enum.GetValues(typeof(difficulty)).GetValue(i);
            LevelTileAttr l = new LevelTileAttr();
            l.x = 975 / xy[i].x;
            l.y = 750 / xy[i].y;
            l.length = (int)xy[i].z;
            levelSetting[i] = new Level(d, l);
        }
        levelAttr = setAttr(level);
    }
    void Start()
    {
        onStart();
    }
    void onStart()
    {
        splitOriginalImage((int)sel.x, (int)sel.y);
        createTiles();
        createTilesPlace();
        if (!isFinish)
        {
            finishGameObject.gameObject.SetActive(false);
            pauseCanvas.gameObject.SetActive(false);
            mainGame.gameObject.SetActive(true);
        }
    }
    void splitOriginalImage(int columns, int rows)
    {
        int spriteWidth = originalImage.width / columns;
        int spriteHeight = originalImage.height / rows;
        List<Sprite> temp = new List<Sprite>();
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            {
                Rect spriteRect = new Rect(x * spriteWidth, y * spriteHeight, spriteWidth, spriteHeight);
                Sprite sprite = Sprite.Create(originalImage, spriteRect, new Vector2(0.5f, 0.5f));

                fragOriginal.Add(sprite);

                // // Create a new GameObject and add a SpriteRenderer component to it
                // GameObject spriteObject = new GameObject("Sprite_" + x + "_" + y);
                // spriteObject.transform.parent = transform;
                // spriteObject.transform.localPosition = new Vector3(x, -y, 0); // Optional: Set the position of the sprite objects

                // SpriteRenderer spriteRenderer = spriteObject.AddComponent<SpriteRenderer>();
                // spriteRenderer.sprite = sprite;
                // break;
            }
            fragOriginal.Reverse();
            foreach (Sprite rmSprite in fragOriginal)
            {
                temp.Add(rmSprite);
            }

            fragOriginal.Clear();
        }
        temp.Reverse();
        frag = temp.ToArray();
    }

    void Update()
    {
        if (isFinish)
        {
            finishGameObject.gameObject.SetActive(true);
            gameOverGameObject.gameObject.SetActive(false);
            mainGame.gameObject.SetActive(false);
            return;
        }
        if (isGameOver)
        {
            mainGame.gameObject.SetActive(false);
            pauseCanvas.gameObject.SetActive(false);
            gameOverGameObject.gameObject.SetActive(true);
            return;
        }
        if (isPause)
        {
            pauseCanvas.gameObject.SetActive(true);
            mainGame.gameObject.SetActive(false);
            gameOverGameObject.gameObject.SetActive(false);
            return;
        }
        else
        {
            pauseCanvas.gameObject.SetActive(false);
            mainGame.gameObject.SetActive(true);
            gameOverGameObject.gameObject.SetActive(false);
        }

        time += Time.deltaTime;
        timeGameObject.text = "" + getTimeInSecond((int)time);
        CheckFinish();

    }

    void CheckFinish()
    {
        if (tilesSpawnPos.transform.childCount == 0)
        {
            isFinish = true;
            return;
        }

        if (time > s1)
        {
            isGameOver = true;
            starSprite1.sprite = starOf;
            starSprite2.sprite = starOf;
            starSprite3.sprite = starOf;
            pauseStarSprite1.sprite = starOf;
            pauseStarSprite2.sprite = starOf;
            pauseStarSprite3.sprite = starOf;
            gameOverStarSprite1.sprite = starOf;
            gameOverStarSprite2.sprite = starOf;
            gameOverStarSprite3.sprite = starOf;
            award.text = "You Lose";
        }
        else if (time > s2)
        {
            starSprite1.sprite = starOn;
            starSprite2.sprite = starOf;
            starSprite3.sprite = starOf;
            pauseStarSprite1.sprite = starOn;
            pauseStarSprite2.sprite = starOf;
            pauseStarSprite3.sprite = starOf;
            award.text = "Nice Try";
        }
        else if (time > s3)
        {
            starSprite1.sprite = starOn;
            starSprite2.sprite = starOn;
            starSprite3.sprite = starOf;
            pauseStarSprite1.sprite = starOn;
            pauseStarSprite2.sprite = starOn;
            pauseStarSprite3.sprite = starOf;
            award.text = "Very Good";
        }
        else
        {
            starSprite1.sprite = starOn;
            starSprite2.sprite = starOn;
            starSprite3.sprite = starOn;
            pauseStarSprite1.sprite = starOn;
            pauseStarSprite2.sprite = starOn;
            pauseStarSprite3.sprite = starOn;
            award.text = "Perfect";
        }
    }
    #region Tile

    private void createTiles()
    {
        fragmentObject = new GameObject[levelAttr.length];
        List<Sprite> sp = new List<Sprite>();
        List<int> shuffleList = new List<int>(); // Algoritma Shuffle / Fisher Yates
        for (int i = 0; i < levelAttr.length; i++)
        {
            shuffleList.Add(i);
        }
        // Debug.Log(JsonUtility.ToJson(shuffleList));

        sp.AddRange(frag);
        for (int i = 0; i < levelAttr.length; i++)
        {
            GameObject fragment = new GameObject("Fragment " + i);
            var image = fragment.AddComponent<Image>();

            image.rectTransform.sizeDelta = new Vector2(levelAttr.x, levelAttr.y);
            image.rectTransform.localPosition = Vector3.zero;
            TileFragment tileFragment = fragment.AddComponent<TileFragment>();


            // Shuffle (Fisher yates)
            var k = UnityEngine.Random.Range(0, sp.Count);
            image.sprite = sp[k];
            tileFragment.tileItem.setID("Frag " + shuffleList[k]);
            sp.RemoveAt(k);
            shuffleList.RemoveAt(k);

            tileFragment.canvas = canvas;
            fragment.transform.SetParent(tilesSpawnPos.transform);
            image.rectTransform.pivot = new Vector2(0.5f, 0.5f);
            fragment.transform.localScale = new Vector3(1, 1, 1);
            var p = image.rectTransform.localPosition;
            p.x += 495.700058f + UnityEngine.Random.Range(-70, 70);
            p.y -= 135.35f + UnityEngine.Random.Range(-50, 50);
            image.rectTransform.localPosition = new Vector3(p.x, p.y, 0f);
            fragmentObject[i] = fragment;
        }
    }
    private void createTilesPlace()
    {
        var tileBox = tilesFather.GetComponent<GridLayoutGroup>();
        tileBox.cellSize = new Vector2(levelAttr.x, levelAttr.y);
        tiles = new GameObject[levelAttr.length];
        for (int i = 0; i < levelAttr.length; i++)
        {
            tileTemplate = new GameObject("Tile " + i);
            Image image = tileTemplate.AddComponent<Image>();
            image.sprite = frag[i];
            var c = image.color;
            c.r = 1f;
            c.g = 1f;
            c.b = 1f;
            c.a = 0.4f;
            image.color = c;
            image.rectTransform.sizeDelta = new Vector2(0, 0);
            tileTemplate.transform.SetParent(tilesFather.transform);
            tileTemplate.transform.localScale = new Vector3(1, 1, 1);
            var tileItem = tileTemplate.AddComponent<TileItem>();
            tileItem.setID("Frag " + i);
            var onDrag = tileTemplate.AddComponent<FragmentEndDrag>();
            onDrag.parent = tilesFather;
            tiles[i] = tileTemplate;
        }
        // Debug.Log(JsonUtility.ToJson(levelAttr, true));
    }
    private void settingGame()
    {
        if (ori != null)
        {
            preview.sprite = ori;
            previewFinish.sprite = ori;
        }

        if (level == TileSpawn.difficulty.Easy)
        {
            s1 = 120;
            s2 = 90;
            s3 = 60;
            sel = new Vector2(4, 3);
        }
        else if (level == TileSpawn.difficulty.Normal)
        {
            s1 = 100;
            s2 = 70;
            s3 = 50;
            sel = new Vector2(5, 4);
        }
        else if (level == TileSpawn.difficulty.Hard)
        {
            s1 = 80;
            s2 = 50;
            s3 = 30;
            sel = new Vector2(6, 5);
        }
        else if (level == TileSpawn.difficulty.VeryHard)
        {
            s1 = 50;
            s2 = 35;
            s3 = 20;
            sel = new Vector2(8, 7);
        }
        star1.text = getTimeInSecond(s1);
        star2.text = getTimeInSecond(s2);
        star3.text = getTimeInSecond(s3);
    }

    private string getTimeInSecond(int second)
    {
        // Debug.Log(second);
        int minute = second / 60;
        second -= (minute * 60);
        String tM = (minute < 10) ? "0" + minute : minute + "";
        String tS = (second < 10) ? "0" + second : second + "";
        return tM + ":" + tS;
    }
    private LevelTileAttr setAttr(difficulty l)
    {
        LevelTileAttr temp = new LevelTileAttr();
        foreach (var item in levelSetting)
        {
            if (item.difficulty == l) temp = item.levelAttr;
        }
        return temp;
    }

    #endregion
    #endregion

}
