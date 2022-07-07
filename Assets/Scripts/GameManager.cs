using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] health;
    public GameObject enemy;
    
    public int arraycontrol;
    public int DeathControl;
    public int _EnemyCount;

    
    void Start()
    {
        arraycontrol = health.Length;
        DeathControl = health.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && arraycontrol > 0)
        {
            health[arraycontrol-1].gameObject.SetActive(false);
            arraycontrol = arraycontrol - 1;
        }
        else if(Input.GetMouseButtonDown(0) && arraycontrol == 0)
        {
            health[0].gameObject.SetActive(false);
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            DeathControl = DeathControl - 1;
        }
        StartCoroutine(timer());
        
    }
    public IEnumerator timer()
    {
        if(DeathControl == 0)
        {
            if (_EnemyCount > 0)
            {
                yield return new WaitForSeconds(1f);
                Time.timeScale = 0;
            }
        }
    }
}
