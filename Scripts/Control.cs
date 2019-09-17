using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public static int health;
    public GameObject live1, live2, live3, gameOver;
    public AudioClip chompSound;
    public AudioSource audioSrc;

    void Start()
    {
        health = 3;
        live1.gameObject.SetActive(true);
        live2.gameObject.SetActive(true);
        live3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
      //   audioSrc.clip = chompSound; //plays audio

    }
    void Update()
    {
        audioSrc.Play();
    if (health > 3)
            health = 4;
        switch (health)
        {
            case 4:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(true);
                live3.gameObject.SetActive(true); //all lives are active if health is = to 3
                break;
            case 3:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(true);
                live3.gameObject.SetActive(false); //disables one of the lives
                break;
            case 2:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(false);
                live3.gameObject.SetActive(false);//disables two of the lives 
                break;
            case 1:
                live1.gameObject.SetActive(false);
                live2.gameObject.SetActive(false);
                live3.gameObject.SetActive(false); //disables all lives
                gameOver.gameObject.SetActive(true);
                Destroy(gameObject);
                Time.timeScale = 0;
                break;
        }
    }
   
}
