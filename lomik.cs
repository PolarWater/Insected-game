using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lomik : MonoBehaviour
{ 
    public float speed = 50f;
    public int damage = 50;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
       enemy enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);     
        }
        Destroy(gameObject);
    }
}
