using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public float score;
    public Text textScore, endScore;
    public Player player;
    public GameObject pauseMenu, resetMenu;
    public bool pause;
    private void Start()
    {
        pauseMenu.SetActive(false);
        resetMenu.SetActive(false);
        player = player.GetComponent<Player>();
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        ScoreAndDeficalty();
        Deafet();
    }
    void ScoreAndDeficalty()
    {
        if (!pause)
        {
            score += 1;
        }
        if (score >= 5000)
        {
            //spawn Platform


        }
        if (score >= 15000)
        {
            //despawn the platfrom on the sides
        }
        textScore.text = "Score: " + score;
    }
    void Deafet()
    {
        if (player.dead)
        {
            Time.timeScale = 0f;
            resetMenu.SetActive(true);
            endScore.text = "Score: " + score;
            pause = true;
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(1);
        
    }
}
