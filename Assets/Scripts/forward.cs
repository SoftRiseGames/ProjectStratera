using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        rb.velocity = transform.up * -1 * 50* Time.deltaTime;
    }
    void Update()
    {
        
    }
}
