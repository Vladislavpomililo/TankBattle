using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //[SerializeField] private Transform player;
    [SerializeField] private Text scoreText;

    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
    }

}
