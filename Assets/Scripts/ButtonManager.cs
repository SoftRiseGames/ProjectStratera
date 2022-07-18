using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public MainMenuScript mainmenumanager;
    public SaveGame saveManager;
    public GameObject levelsAll;
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
}
