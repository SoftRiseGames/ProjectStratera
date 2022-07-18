using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class ButtonManager : MonoBehaviour
{
    public MainMenuScript mainmenumanager;
    public SaveGame saveManager;
    public GameObject levelsAll;
    public LevelManager levelmanager;
    private int levelvalue = 1;

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
