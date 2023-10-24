using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Variables for timer 
    public float WaitSec;
    public int WaitSecInt;  //text
    public Text time;


    private void FixedUpdate()
    {
        //Begins timer from set time to 0
        if(WaitSec > 0) 
        {
            WaitSec -= Time.fixedDeltaTime;
            WaitSecInt = (int)WaitSec;
            time.text = WaitSecInt.ToString();
  
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   //Reset scene 
            Score.scoreValue = 0;   //Resets score 
        }    
    }
}
