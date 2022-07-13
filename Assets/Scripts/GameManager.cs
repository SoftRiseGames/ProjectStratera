using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject[] health;
    public GameObject enemy;
    
    public int arraycontrol;
    public int DeathControl;
    public int _EnemyCount;
    public bool _isGun;
    public GameObject TimeLine;
    public Collision2D collide;
    public Canvas restart;
    public GameObject windowoff;
    
    public bool isCollide;
    void Start()
    {
        arraycontrol = health.Length;
        DeathControl = health.Length;
        _isGun = true;
        GameObject.Find("TimeLine");
        restart = GameObject.Find("Restart").GetComponent<Canvas>();
        
        TimeLine.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        windowoff.gameObject.SetActive(false);
        Time.timeScale = 1;
        
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
            TimeLine.gameObject.SetActive(true);
        }
    }
    public IEnumerator timer()
    {
        if (DeathControl == 0)
        {
            yield return new WaitForSeconds(1f);
            if (_EnemyCount > 0)
            {
                windowoff.gameObject.SetActive(true);
                yield return new WaitForSeconds(0.2f);
                Time.timeScale = 0;
                restart.gameObject.SetActive(true);
            }
        }
        if(_EnemyCount == 0)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (isCollide == true)
        {
            windowoff.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
        }

        
    }

    
    

}
