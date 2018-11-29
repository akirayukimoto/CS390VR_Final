using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    // Use this for initialization
    public float second;
    public int minute;

    public Text time_text;
    //public Text time_text_2;
    public float second_final;
    public int minute_final;

    public bool update_time;

    void Start()
    {
        second = 0;
        minute = 0;
        update_time = true;
    }

    // Update is called once per frame
    void Update()
    {
        // left black
        if (update_time)
        {
            second = second + Time.deltaTime;
            time_text.text = "Time: " + minute + "'" + second + "''";
            //time_text_2.text = "You already used:" + minute + "'" + second + "''";
            if (second >= 60)
            {
                minute++;
                second = 0;
            }
        }
    }
}
