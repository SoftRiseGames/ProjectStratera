using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonManager : MonoBehaviour
{
    public MainMenuScript mainmenumanager;
    public SaveGame saveManager;
    public GameObject levelsAll;
    private int levelvalue = 1;
    public GameObject gameplayMusic;
    public GameManager gameManager;
  
    private void Start()
    {
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
    private void Update()
    {
        
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
}
