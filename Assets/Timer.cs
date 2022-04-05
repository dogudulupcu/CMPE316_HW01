using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
public Text timerText;
private bool finished =false;
private string minutes;
private string seconds;
public static string  started="stop";
private float StartTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(finished)
        {
            return;
        }
        if(started.Equals("start") ){
        float t= Time.time - StartTime;
         minutes = ((int)t / 60).ToString();
         seconds = (t % 60).ToString("f2");
        
        }

    }

    public void Finish(){
        finished=true;
        timerText.color=Color.red;
        Time.timeScale=0;
        timerText.text="Finished "+minutes+":"+seconds; 
    }

    public void TimeStart(){
       started="start"; 
       StartTime=Time.time;
    }
}
