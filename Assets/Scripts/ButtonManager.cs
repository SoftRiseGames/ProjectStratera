using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonManager : MonoBehaviour
{
    public MainMenuScript mainmenumanager;
    public GameObject levelsAll;
    private int levelvalue = 1;
    public GameObject gameplayMusic;
    public GameManager gameManager;
    
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        levelvalue = PlayerPrefs.GetInt("levelvolume");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Retry()
    {
        gameManager.soundcheckvalue = 1;
        PlayerPrefs.SetInt("soundcheckvalue", gameManager.soundcheckvalue);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
    public void welcome()
    {
        StartCoroutine(mainmenumanager.welcome());
    }
    public void levels()
    {
        levelsAll.gameObject.SetActive(true);
    }
    public void levelclose()
    {
        levelsAll.gameObject.SetActive(false);
    }
    public void levelchoose()
    {
        SceneManager.LoadScene(int.Parse(gameObject.name));
        if (PlayerPrefs.GetInt("levelvolume") == 1)
        {
            gameplayMusic.gameObject.SetActive(true);
            DontDestroyOnLoad(gameplayMusic);
        }
        else if (PlayerPrefs.GetInt("levelvolume") == 0)
        {
            gameplayMusic.gameObject.SetActive(false);
        }
    }
    public void volume()
    { 
        if (PlayerPrefs.GetInt("levelvolume") == 1)
        {
            levelvalue = 0;
            PlayerPrefs.SetInt("levelvolume", levelvalue);
        }
        else if(PlayerPrefs.GetInt("levelvolume") == 0)
        {
            levelvalue = 1;
            PlayerPrefs.SetInt("levelvolume", levelvalue);
        }
        Debug.Log(PlayerPrefs.GetInt("levelvolume"));
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
        
    }
    public void Resume()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        gameManager.stopbool = false;
        Time.timeScale = 1;
    }
    public void StopMenu()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.stopbool = true;
        Time.timeScale = 0;
    }
    public void quit()
    {
        Application.Quit();
    }
}
