using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject poz;
    void Start()
    {
        rb.AddForce(GameObject.Find("poz").GetComponent<Rigidbody2D>().transform.up * 50, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
