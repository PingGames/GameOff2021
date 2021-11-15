using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    TextMeshProUGUI timeUI; // TimeCounter UI
    float startTime; //T ime when player clicks on Play
    float ellapsedTime; // Ellapsed time after clicking play
    bool startCounter; //F lag to start counter

    int hours;
    int minutes;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        startCounter = false;

        // Get Text UI Component feom this GO
        timeUI = GetComponent<TextMeshProUGUI> ();
    }

    // Function to start timer
    public void StartTimeCounter()
    {
        startTime = Time.time;
        startCounter = true;
    }

    //Function to stop time counter
    public void StopTimeCounter()
    {
        startCounter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startCounter)
        {
            // Compute the ellapsed time
            ellapsedTime = Time.time - startTime;

            //hours = (int)ellapsedTime
            minutes = (int)ellapsedTime / 60; // Get the minutes
            seconds = (int)ellapsedTime % 60; // Get the seconds

            // Update the time counter UI Text
            timeUI.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }
}
