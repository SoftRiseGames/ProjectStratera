using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject _particles;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameManager._EnemyCount = gameManager._EnemyCount - 1;
            Destroy(this.gameObject);
            Instantiate(_particles, transform.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Collide")
        {
            Time.timeScale = 0;
        }
    }
}
