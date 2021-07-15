using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text recordText;

    public GameObject myJoistick;
    public GameObject myPause;
    public GameObject myBolt;
    public GameObject myGameOver;

    public PlayerController playerController;
    private bool isRecord = true;

    private void Update()
    {
        if(playerController == null && isRecord == true)
        {
            myGameOver.SetActive(true);
            myBolt.SetActive(false);
            myPause.SetActive(false);
            myJoistick.SetActive(false);
            Time.timeScale = 1;
            recordText.text ="Очки:" + Score.score.ToString();
            isRecord = false;
        }

    }
}
