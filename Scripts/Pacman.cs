using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour {
    public static int speed = 4;
    private Vector2 direction = Vector2.zero;
 //   public static int health;
   // public GameObject live1, live2, live3, gameOver;
	void Start () {
        //health = 3;
        //live1.gameObject.SetActive(true);
        //live2.gameObject.SetActive(true);
        //live3.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive(false);
    }
	void Update () {
        CheckInput();
        Move();
        UpdateOrientation();

        //if (health > 3)
        //    health = 3;
        //switch (health)
        //{
        //    case 3:
        //        live1.gameObject.SetActive(true);
        //        live2.gameObject.SetActive(true);
        //        live3.gameObject.SetActive(true); //all lives are active if health is = to 3
        //        break;
        //    case 2:
        //        live1.gameObject.SetActive(true);
        //        live2.gameObject.SetActive(true);
        //        live3.gameObject.SetActive(false); //disables one of the lives
        //        break;
        //    case 1:
        //        live1.gameObject.SetActive(true);
        //        live2.gameObject.SetActive(false);
        //        live3.gameObject.SetActive(false);//disables two of the lives 
        //        break;
        //    case 0:
        //        live1.gameObject.SetActive(false);
        //        live2.gameObject.SetActive(false);
        //        live3.gameObject.SetActive(false); //disables all lives
        //        gameOver.gameObject.SetActive(true);
        //        Time.timeScale = 0;
        //        break;
        //} //moved this to its own script
	}
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           direction= Vector2.right;
        }
            if (Input.GetKeyDown(KeyCode.W))
        {
           direction = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           direction = Vector2.down;
        }
    }
    void Move()
    {
        transform.localPosition += (Vector3)(direction *speed) * Time.deltaTime;
    }
    void UpdateOrientation() //rotates character
    {
        if (direction == Vector2.left)
        {
            transform.localScale = new Vector3(-3, 3, 3);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (direction == Vector2.right)
        {
            transform.localScale = new Vector3(3, 3, 3);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (direction == Vector2.up)
        {
            transform.localScale = new Vector3(3, 3, 3);
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (direction == Vector2.down)
        {
            transform.localScale = new Vector3(3, 3, 3);
            transform.localRotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
