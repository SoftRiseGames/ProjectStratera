using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator _animControl;
    public GameManager gameManager;
    void Start()
    {
        _animControl = GameObject.Find("Gun").GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameManager.DeathControl>0)
        {
            Instantiate(bullet, rb.transform.position, rb.transform.rotation);
            _animControl.enabled = false;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animControl.enabled = true;
        }
    }
}
