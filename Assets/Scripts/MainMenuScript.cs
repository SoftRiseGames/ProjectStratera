using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject TimeLineWelcome;
    public SaveGame savebool;
    int value;
    private void Start()
    {
        TimeLineWelcome.gameObject.SetActive(false);
        Debug.Log(PlayerPrefs.GetInt("isstartgame"));

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            savebool.value = 0;
            PlayerPrefs.SetInt("isstartgame", savebool.value);
            Debug.Log(PlayerPrefs.GetInt("isstartgame"));
        }
    }
    public IEnumerator welcome()
    {
        TimeLineWelcome.gameObject.SetActive(true);
       
        if(PlayerPrefs.GetInt("isstartgame") == 0)
        {
            
            
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene(1);
            savebool.value = 1;
            PlayerPrefs.SetInt("isstartgame", savebool.value);
            Debug.Log(PlayerPrefs.GetInt("isstartgame"));
            yield return new WaitForSeconds(5);
           

        }
      
        if(PlayerPrefs.GetInt("isstartgame") == 1)
        {
           
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene(PlayerPrefs.GetInt("go"));
        }
       

    }
   
}
