using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] health;
    public int arraycontrol;
    public int DeathControl;
    
    void Start()
    {
        arraycontrol = health.Length;
        DeathControl = health.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DeathControl = DeathControl - 1;
        }
        if (Input.GetMouseButtonDown(0) && arraycontrol > 0)
        {
            health[arraycontrol-1].gameObject.SetActive(false);
            arraycontrol = arraycontrol - 1;
           
        }
        
        if(DeathControl == -1)
        {
            Time.timeScale = 0;
        }

        Debug.Log(DeathControl);
    }
}
