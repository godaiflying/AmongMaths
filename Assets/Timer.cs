using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   
    public double timeleft = 10.0;
    public Text TimerOutput;
    public Slider Timeslider;
    double timerCouter;
    // Update is called once per frame
    void Update()
    {
        timerCouter -= Time.deltaTime;

        TimerOutput.text = timerCouter.ToString("f2");
        float timerfloat = Convert.ToSingle(timerCouter);
        Timeslider.value = timerfloat;

        if(timerfloat < 0.01 && timerfloat > -0.01)
        {
            Endgame();
        }
    }
    public void Start()
    {
        timerCouter = timeleft;
    }

    private void Endgame()
    {
        SceneManager.LoadScene(2);
    }
}
