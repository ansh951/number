using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Slider timeSlider;
    public float remaingTime;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        timeSlider.maxValue = remaingTime;
        timeSlider.value = remaingTime;
    }


    private void Update()
    {
        if(remaingTime > 0)
        {
            remaingTime -= Time.deltaTime;
        }

        else if (remaingTime < 0)
        {
            remaingTime = 0;
            gameOverPanel.SetActive (true);
        }

        int minutes = Mathf.FloorToInt(remaingTime / 60);
        int seconds = Mathf.FloorToInt(remaingTime % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        timeSlider.value = remaingTime;
    }
}
