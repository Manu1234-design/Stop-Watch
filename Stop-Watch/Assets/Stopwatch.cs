using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{

    float timer;
    float seconds;
    float minutes;
    float hours;

    bool start;


    [SerializeField] Text stopWatchText;

    // Start is called before the first frame update
    void Start()
    {
        start = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StopWatchCalcul();
    }

    void StopWatchCalcul(){

        if (start){
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)((timer / 60) % 60);
        hours = (int)(timer / 3600);

        stopWatchText.text = hours.ToString ("00") + ":" + minutes.ToString ("00") + ":" + seconds.ToString ("00");
        }
        
    }

    public void startTimer(){
        start = true;
    }

    public void stopTimer(){
        start = false;
    }

    public void resetTimer(){
        start = false;
        timer = 0;
        stopWatchText.text = "00:00:00";
    }
}
