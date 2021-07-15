using System.Collections;
using UnityEngine;

public class SpownBot : MonoBehaviour
{
    
    [SerializeField] private GameObject bot;
    [SerializeField] private float timeSpownBot;

    private float[] positions = { 2.25f,2.10f,1.95f,1.80f,1.65f,1.50f,1.35f,1.20f,1.05f,0.90f,0.75f,0.60f,0.45f,0.30f,
                                 0.15f,0,-2.10f,-1.95f,-1.80f,-1.65f,-1.50f,-1.35f,-1.20f,-1.05f,-0.90f,-0.75f,-0.60f,
                                -0.45f,-0.30f,-0.15f,-2.25f};

    void Start()
    {
        StartCoroutine(spawn());
    }
    
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(
                 bot,
                new Vector3(positions[Random.Range(0, 31)], 6f, 0),
                Quaternion.Euler(new Vector3(0, 0, 90))
                );
            yield return new WaitForSeconds(timeSpownBot);
        }
    }
}
