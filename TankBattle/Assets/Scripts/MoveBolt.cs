using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBolt : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float speed;

    [SerializeField] private GameObject boomBoltPrefab;
    [SerializeField] private GameObject boomPrefab;

    [SerializeField] private int scoreValue = 10;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -speed;
    }

    private void FixedUpdate()
    {
        if (transform.position.y > 7)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bot")
        {
            var clone = Instantiate(boomBoltPrefab, GetComponent<Rigidbody2D>().position, transform.rotation);
            var objBoom = other.gameObject;
            var clonez = Instantiate(boomPrefab, objBoom.GetComponentInParent<Rigidbody2D>().position, transform.rotation);
            Destroy(clone, 1f);
            Destroy(clonez, 1f);
            Destroy(other.gameObject);
            Destroy(gameObject);

            Score.AddScore(scoreValue);

        }
        if (other.tag == "BoltBot")
        {
            var clone = Instantiate(boomBoltPrefab, GetComponent<Rigidbody2D>().position, transform.rotation);
            var objBoom = other.gameObject;
            var clonez = Instantiate(boomBoltPrefab, objBoom.GetComponentInParent<Rigidbody2D>().position, transform.rotation);
            Destroy(clone, 1f);
            Destroy(clonez, 1f);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
