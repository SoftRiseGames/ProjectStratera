using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject TimeLineWelcome;
    public SaveGame savebool;
    public GameObject music;
    public GameObject gameplayMusic;

    
    private void Start()
    {
        TimeLineWelcome.gameObject.SetActive(false);

    private void Start()
    {
        TimeLineWelcome.gameObject.SetActive(false);
        Debug.Log(PlayerPrefs.GetInt("levelvolume"));

>>>>>>> parent of 50d424e (Particles)
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            savebool.value = 0;
            PlayerPrefs.SetInt("isstartgame", savebool.value);
            Debug.Log(PlayerPrefs.GetInt("isstartgame"));
        }

        if(PlayerPrefs.GetInt("levelvolume") == 1)
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
       
        if(PlayerPrefs.GetInt("isstartgame") == 0)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(1);
            savebool.value = 1;
            PlayerPrefs.SetInt("isstartgame", savebool.value);
            Debug.Log(PlayerPrefs.GetInt("isstartgame"));
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
      
        if(PlayerPrefs.GetInt("isstartgame") == 1)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(PlayerPrefs.GetInt("go"));

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
   
}
