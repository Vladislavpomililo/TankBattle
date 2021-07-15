using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBot : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeShotBolt;


    [SerializeField] private GameObject shot;
    [SerializeField] private Transform shotSpawnPlayer;
    
    void Start()
    {

        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {     
            Instantiate(shot, shotSpawnPlayer.position, shotSpawnPlayer.rotation );
            yield return new WaitForSeconds(timeShotBolt);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.y < -8)
            Destroy(gameObject);
       
    }

}
