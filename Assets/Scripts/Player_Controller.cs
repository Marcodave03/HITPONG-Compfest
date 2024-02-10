using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;
    
    private float speed;
    private bool moveUp;
    private bool moveDown;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        moveUp = false;
        moveDown = false;
    }

    public void PointerDownLeft() {
        moveUp = true;
    }

    public void PointerUpLeft() {
        moveUp = false;
    }

    public void PointerDownRight() {
        moveDown = true;
    }

    public void PointerUpRight() {
        moveDown = false;
    }

    private void FixedUpdate() {

        // For Test
        // if (Input.GetAxis("Vertical") > 0.0f) {
        //     moveUp = true;
        //     moveDown = false;
        // } else if (Input.GetAxis("Vertical") < 0.0f) {
        //     moveUp = false;
        //     moveDown = true;
        // } else {
        //     moveUp = false;
        //     moveDown = false;
        // }

        // Mobile
        if (moveUp) {
            speed += Time.deltaTime * 15;
            if (speed > 5.0f) {
                speed = 5.0f;
            }
            movement = new Vector3(0, speed, 0.0f);
            rb.velocity = new Vector2(movement.x, movement.y);
        } else if (moveDown) {
            speed -= Time.deltaTime * 15;
            if (speed < -5.0f) {
                speed = -5.0f;
            }
            movement = new Vector3(0, speed, 0.0f);
            rb.velocity = new Vector2(movement.x, movement.y);
        } else {
            if (speed > -0.3f && speed < 0.3f) {
                speed = 0;
            } else if (speed > 0.3f) {
                speed -= Time.deltaTime * 30;
            } else if (speed < -0.3f) {
                speed += Time.deltaTime * 30;
            }
            movement = new Vector3(0, speed, 0.0f);
            rb.velocity = new Vector2(movement.x, movement.y);
        }
    }
}
