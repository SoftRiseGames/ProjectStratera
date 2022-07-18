using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voicesettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("levelvolume") == 1)
        {
            this.gameObject.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("levelvolume") == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
