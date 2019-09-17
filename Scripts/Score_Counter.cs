using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score_Counter : MonoBehaviour {
public static int score_Integer = 0;
    Text score;
    public string win;
    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();

      
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + score_Integer;

        if (score_Integer == 235)
        {
            SceneManager.LoadScene(win); //loads win screen upon completion
            
        }
            }       
}
