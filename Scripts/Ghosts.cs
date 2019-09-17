using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghosts : MonoBehaviour {
    public Transform[] waypoints;
    int cur = 0;
    public float MoveSpeed = 0.1f;
    public AudioClip death;
    public AudioSource audioSrc;
    void Start () {
        audioSrc.clip = death; //plays audio
    }
	
	void FixedUpdate () {
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, MoveSpeed);//follows waypoints
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
        else cur = (cur + 1) % waypoints.Length;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        { //destroys player on collision using tags           
            Control.health -= 1;
            audioSrc.Play();
        }
        if (Control.health <= 0)
        {
            Destroy(other.gameObject);
            audioSrc.Play(); 
        }
    }
}
