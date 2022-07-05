using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject poz;
    void Start()
    {
        rb.AddForce(GameObject.Find("poz").GetComponent<Rigidbody2D>().transform.up * 70, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
