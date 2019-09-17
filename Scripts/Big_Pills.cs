using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Pills : MonoBehaviour {
    public AudioClip life;
    public AudioSource audioSrc;
    void Start()
    {
        audioSrc.clip = life; //plays audio
    }
    void OnTriggerEnter2D(Collider2D other) { 
     if (other.gameObject.tag == "Player")
        { //destroys player on collision using tags           
            Control.health += 1; // gives pacman a life upon collection
            Pacman.speed += 1; //speed boost per pill collection
            Destroy(gameObject);
            audioSrc.Play();
        }
        
        
}
}
