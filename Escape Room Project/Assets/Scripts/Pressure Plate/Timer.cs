using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool active = false;
    public bool finished = false;
    public float time = 30;
    public TextMeshProUGUI timer;

    private void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();    
    }

    private void Update()
    {
        if (active && finished == false)
        {
            time -= Time.deltaTime;
            timer.SetText(time.ToString("0.0"));
        }
    }

    public void Deactivate() // resets the timer / trap
    {
        if(finished == false)
        {
            active = false;
            time = 30;
            timer.SetText("" + time);
        }
    }

    public void Finished() // marks trap as finished, makes it completely inactive
    {
        if(finished == false)
        {
            finished = true;
            active = false;
            timer.color = Color.green;
        } 
    }
}
