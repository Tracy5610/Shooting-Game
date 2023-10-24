using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    //Variables
    public static int scoreValue = 0;
    Text score; //Text

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();   // Reference to score text
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue; // Format of score display 
    }
   
}
