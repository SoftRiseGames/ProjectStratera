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
    public bool _isGun;
    
    void Start()
    {
        arraycontrol = health.Length;
        DeathControl = health.Length;
        _isGun = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && arraycontrol > 0 && _isGun ==true)
        {
            health[arraycontrol-1].gameObject.SetActive(false);
            arraycontrol = arraycontrol - 1;
        }
        else if(Input.GetMouseButtonDown(0) && arraycontrol == 0 && _isGun == true)
        {
            health[0].gameObject.SetActive(false);
        }
        
        if (Input.GetMouseButtonDown(0) && _isGun == true)
        {
            DeathControl = DeathControl - 1;
        }
        StartCoroutine(timer());
        if(_EnemyCount == 0)
        {
            Debug.Log("Geçtin");
            _isGun = false;
        }
    }
    public IEnumerator timer()
    {
        if (DeathControl == 0)
        {
            yield return new WaitForSeconds(1f);
            if (_EnemyCount > 0)
            {
                Time.timeScale = 0;
            }
        }
    }
}
