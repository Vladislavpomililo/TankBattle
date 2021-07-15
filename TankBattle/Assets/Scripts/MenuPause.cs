using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] private GameObject myPause;

    private void Start()
    {
        
    }

    public void Pause()
    {
        if (!isPaused)
        {
            myPause.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
        else if(isPaused)
        {
            myPause.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
