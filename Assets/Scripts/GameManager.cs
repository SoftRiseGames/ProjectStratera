using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
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
    public GameObject background;
    public bool isCollide;
    public int musicControl;
    public int soundcheckvalue = 1;
    public bool isfire;
    void Start()
    {
        arraycontrol = health.Length;
        DeathControl = health.Length;
        _isGun = true;
        TimeLine.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        windowoff.gameObject.SetActive(false);
        Time.timeScale = 1;
        soundcheckvalue = 1;
        isfire = false;
    }
    
    void Update()
    {
        StartCoroutine(wait());
        if (!EventSystem.current.IsPointerOverGameObject() &&isfire ==true)
        {
            if (Input.GetMouseButtonDown(0) && arraycontrol > 0 && _isGun == true)
            {
                health[arraycontrol - 1].gameObject.SetActive(false);
                arraycontrol = arraycontrol - 1;
            }
            else if (Input.GetMouseButtonDown(0) && arraycontrol == 0 && _isGun == true)
            {
                health[0].gameObject.SetActive(false);
            }

            if (Input.GetMouseButtonDown(0) && _isGun == true)
            {
                DeathControl = DeathControl - 1;
            }
        }

        StartCoroutine(timer());
       
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
                soundcheckvalue = 0;
                PlayerPrefs.SetInt("soundcheckvalue", soundcheckvalue);
            }
        }
        if(_EnemyCount == 0)
        {
            Debug.Log("Geçtin");
            _isGun = false;
            TimeLine.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            PlayerPrefs.SetInt("go", SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("go"));
        }

        if (isCollide == true)
        {
            
            windowoff.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
            soundcheckvalue = 0;
            PlayerPrefs.SetInt("soundcheckvalue", soundcheckvalue);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.9f);
        isfire = true;
    }
}
