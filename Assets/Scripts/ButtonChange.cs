using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonChange : MonoBehaviour
{
    [SerializeField] Sprite voiceOn;
    [SerializeField] Sprite voiceOff;

    int buttonvalue = 1; 
    void Start()
    {
        PlayerPrefs.GetInt("levelvolume");
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("levelvolume") == 1)
        {
            GetComponent<Image>().sprite = voiceOn;
        }
        else if (PlayerPrefs.GetInt("levelvolume") == 0)
        {
            GetComponent<Image>().sprite = voiceOff;
        }
    }

    public void voicebuttonchange()
    {
        if(PlayerPrefs.GetInt("levelvolume") == 1)
        {
            GetComponent<Image>().sprite = voiceOn;
            buttonvalue = 1;
            PlayerPrefs.SetInt("buttonvalue", buttonvalue);
        }
        else if (PlayerPrefs.GetInt("levelvolume") == 0)
        {
            GetComponent<Image>().sprite = voiceOff;
            buttonvalue = 0;
            PlayerPrefs.SetInt("buttonvalue", buttonvalue);
        }
    }
}
