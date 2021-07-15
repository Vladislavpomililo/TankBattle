using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax, playerLineSpawn;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    public Boundary boundary;
    public float tilt;

    [SerializeField] private GameObject boomPrefab;
    [SerializeField] private GameObject boomBoltPrefab;

    [SerializeField] private int health;
    [SerializeField] private int numberOfLives;
    [SerializeField] private Text healthText;

    public GameObject shot;
    public Transform shotSpawnPlayer;
    public float fireRate = 0.5f;
    public float nextFite = 0.0f;

    [SerializeField] public Joystick joystick;// просто закинь сюда джойстик
    [SerializeField] private Rigidbody2D rb; //компонент риджитбади игрока
    private float moveInput;

    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        healthText.text = health.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bot" )
        {
            var clone = Instantiate(boomPrefab, GetComponent<Rigidbody2D>().position, transform.rotation);
            var objBoom = other.gameObject;
            var clonez = Instantiate(boomPrefab, objBoom.GetComponentInParent<Rigidbody2D>().position, transform.rotation);
            Destroy(clone, 1f);
            Destroy(clonez, 1f);
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        if (other.tag == "BoltBot")
        {
            if (health == 0)
            {
                
                var clone = Instantiate(boomPrefab, GetComponent<Rigidbody2D>().position, transform.rotation);
                var objBoom = other.gameObject;
                var clonez = Instantiate(boomBoltPrefab, objBoom.GetComponentInParent<Rigidbody2D>().position, transform.rotation);
                Destroy(clone, 1f);
                Destroy(clonez, 1f);
                Destroy(other.gameObject);
                Destroy(gameObject);
                
            }
            else
            {
                var objBoom = other.gameObject;
                var clonez = Instantiate(boomBoltPrefab, objBoom.GetComponentInParent<Rigidbody2D>().position, transform.rotation);
                Destroy(clonez, 1f);
                Destroy(other.gameObject);
                health -= 1;
            }
        }
       
    }
   
}
