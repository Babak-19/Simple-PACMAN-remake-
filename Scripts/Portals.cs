using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour {
    public GameObject Teleportation_Point;
    public GameObject Player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") //uses the player tag to check if the player has made contact with the empty box collider
        {
            StartCoroutine(Teleport());
         
        }
    }
    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0.2f); //begins the teleportation 0.2s after contact has been made
        Player.transform.position = new Vector2(Teleportation_Point.transform.position.x, Teleportation_Point.transform.position.y); //teleports the players x and y values
    }

   
}
