using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBoltBot : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -speed;
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -8)
            Destroy(gameObject);
    }

}
