using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject TimeLineWelcome;
    public GameObject music;
    public GameObject gameplayMusic;
    public int levelcontroller;
    private void Start()
    {
      Time.timeScale = 1;
      TimeLineWelcome.gameObject.SetActive(false);
      Debug.Log(PlayerPrefs.GetInt("levelvolume"));
      
    }
    private void Update()
    {
       

        if (PlayerPrefs.GetInt("levelvolume") == 1)
        {
            music.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("levelvolume") == 0)
        {
            music.gameObject.SetActive(false);
        }
    }
    public IEnumerator welcome()
    {
        TimeLineWelcome.gameObject.SetActive(true);

        if (PlayerPrefs.GetInt("go") == 0)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(1);
        }
        else if(PlayerPrefs.GetInt("go") > 0)
        {
            Debug.Log("aldý");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(PlayerPrefs.GetInt("go"));
        }
        
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
}
