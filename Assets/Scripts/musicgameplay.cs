using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class musicgameplay : MonoBehaviour
{
    public AudioSource _voice;
    void Start()
    {
        PlayerPrefs.GetInt("soundcheckvalue");
        _voice = GetComponent<AudioSource>();
        _voice.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("soundcheckvalue") == 1)
        {
            if (_voice.volume <= 1)
            {
                _voice.volume += 0.20f*Time.deltaTime;
            }
        }
        else if (PlayerPrefs.GetInt("soundcheckvalue") == 0)
        {
            _voice.volume = 0;
        }
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
