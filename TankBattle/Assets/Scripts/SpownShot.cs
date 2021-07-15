using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownShot : MonoBehaviour
{
    [SerializeField] private Transform shotPos;
    [SerializeField] private GameObject rocket;
    int howShot;

    [SerializeField] private float coolDownTime;
    private float nextFire = 0;

    private void Start()
    {
        howShot = 0;

    }

    private void Update()
    {
        if (howShot == 25)
        {
            StartCoroutine(Gun());
        }
    }

    public void Shot()
    {
        if (Time.time > nextFire)
        {
            if (howShot < 25)
            {
                Instantiate(rocket, shotPos.transform.position, transform.rotation);
                howShot += 1;
                nextFire = Time.time + coolDownTime;
            }
        }
    }

    IEnumerator Gun()
    {
        yield return new WaitForSeconds(4);
        howShot = 0;
    }
}
