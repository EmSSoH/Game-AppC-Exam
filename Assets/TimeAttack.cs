using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeAttack : MonoBehaviour
{

    bool stop = false;
    float currentTime = 0f;

    public GameObject win;
    [SerializeField] Text Highscore;
    [SerializeField] Text attackTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            currentTime += 1 * Time.deltaTime;
            attackTime.text = currentTime.ToString("0.000");
            
        }


    }

    public void Finish()
    {
        stop = true;
        win.SetActive(true);
        attackTime.text = "your Time: " + currentTime.ToString("0.000");

        if (SceneManager.Equals(SceneManager.GetSceneByName("Car"), SceneManager.GetActiveScene()))
        {
            if (currentTime < PlayerPrefs.GetFloat("HighScoreCar", 999999))
            {
                PlayerPrefs.SetFloat("HighScoreCar", currentTime);
            }

            Highscore.text = "HighScore: " + PlayerPrefs.GetFloat("HighScoreCar").ToString();
        }

        if (SceneManager.Equals(SceneManager.GetSceneByName("Air"), SceneManager.GetActiveScene()))
        {
            if (currentTime < PlayerPrefs.GetFloat("HighScoreAir", 999999))
            {
                PlayerPrefs.SetFloat("HighScoreAir", currentTime);
            }

            Highscore.text = "HighScore: " + PlayerPrefs.GetFloat("HighScoreAir").ToString();
        }

        if (SceneManager.Equals(SceneManager.GetSceneByName("Shooter"), SceneManager.GetActiveScene()))
        {
            if (currentTime < PlayerPrefs.GetFloat("HighScoreShooter", 999999))
            {
                PlayerPrefs.SetFloat("HighScoreShooter", currentTime);
            }

            Highscore.text = "HighScore: " + PlayerPrefs.GetFloat("HighScoreShooter").ToString();
        }
    }

    public void Reset()
    {
        if (SceneManager.Equals(SceneManager.GetSceneByName("Car"), SceneManager.GetActiveScene()))
        {
            PlayerPrefs.DeleteKey("HighScoreCar");
        }

        if (SceneManager.Equals(SceneManager.GetSceneByName("Air"), SceneManager.GetActiveScene()))
        {
            PlayerPrefs.DeleteKey("HighScoreAir");
        }

        if (SceneManager.Equals(SceneManager.GetSceneByName("Shooter"), SceneManager.GetActiveScene()))
        {
            PlayerPrefs.DeleteKey("HighScoreShooter");
        }
    }

}
