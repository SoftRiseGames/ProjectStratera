using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public Button[] buttons;
    void Start()
    {
        PlayerPrefs.GetInt("levelbuttons");
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < buttons.Length && i<PlayerPrefs.GetInt("go");)
        {
            buttons[i].gameObject.SetActive(true);
            i++;
            PlayerPrefs.SetInt("levelbuttons", i);
        }
    }
}
