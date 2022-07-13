using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject TimeLineWelcome;
    private void Start()
    {
        TimeLineWelcome.gameObject.SetActive(false);
    }
    public IEnumerator welcome()
    {
        TimeLineWelcome.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
