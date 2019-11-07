using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] GameStat gameStats;
    [SerializeField] GameObject player;
    [SerializeField] Transform startPos;
    [SerializeField] Text pointText;
    [SerializeField] Text timeText;
    [SerializeField] Text highScoreText;
    private float yourHighscore;
    private int current_level;
    public GameObject[] pauseObjects;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        current_level = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            gameStats.score = 0;
        }
        time = 0;
        UpdatePointtext();
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
        showHighScore();
    }

    private void Update()
    {
        //pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
        time = time + Time.deltaTime;
        showTime();
        
    }
   public void showHighScore()
    {
        Debug.Log(gameStats.highscore[current_level]);
        highScoreText.text = "Highscore: " + gameStats.highscore[current_level];
    }
    public void showTime()
    {
        timeText.text = "Time: " + time;
    }
    public void PlayerPickedUpPoints()
    {
        gameStats.score = gameStats.score + 10;
        UpdatePointtext();
    }

    public void UpdatePointtext()
    {
        pointText.text = "Score: " + gameStats.score;
    }
    public void Reload()
    {

        SceneManager.LoadScene(current_level);
        gameStats.score = 0;
    }
    public void LoadLevel(int level)
    {
        checkHighScore();
        SceneManager.LoadScene(level);
    }
    public void checkHighScore()
    {
        yourHighscore = time;
        if (yourHighscore < gameStats.highscore[current_level])
        {
            gameStats.highscore[current_level] = yourHighscore;
        }
    }

    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    public void skipRampe()
    {
        Vector3 pos = new Vector3((float)1.146,
                                  (float)0.4767,
                                  (float)3.022);
        
        player.transform.position = pos;
    }
}
