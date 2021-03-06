using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public Button[] buttons;
    public int levelcount;
    public int buttoncheck;
    public int go;
    void Start()
    {
        PlayerPrefs.GetInt("go");
        PlayerPrefs.GetInt("buttoncheck");
    }

    // Update is called once per frame
    void Update()
    {
        levelcontrol();
    }
    void levelcontrol()
    {
        if (PlayerPrefs.GetInt("buttoncheck") <= PlayerPrefs.GetInt("go"))
        {
            buttoncheck = PlayerPrefs.GetInt("go");
            PlayerPrefs.SetInt("buttoncheck", buttoncheck);
        }
        

        for (; levelcount < buttons.Length && levelcount < PlayerPrefs.GetInt("buttoncheck");)
        {
            buttons[levelcount].gameObject.SetActive(true);
            levelcount++;
        }
    }
}
