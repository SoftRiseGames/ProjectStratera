using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEditor : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    public void artis()
    {
        gameManager._EnemyCount = gameManager._EnemyCount + 1;
        Instantiate(gameManager.enemy,GameObject.Find("enemy").transform);
    }
}
