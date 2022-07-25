using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator _animControl;
    public GameManager gameManager;
    void Start()
    {
        _animControl = GameObject.Find("Gun").GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0) && gameManager.DeathControl > 0 && gameManager._isGun == true)
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
}
