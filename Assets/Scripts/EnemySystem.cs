using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject _particles;
    public AudioClip shootvoice;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameManager._EnemyCount = gameManager._EnemyCount - 1;
            AudioSource.PlayClipAtPoint(shootvoice,Camera.main.transform.position);
            Destroy(this.gameObject);
            Instantiate(_particles, transform.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Collide")
        {
            gameManager.isCollide = true;
        }
    }
}
