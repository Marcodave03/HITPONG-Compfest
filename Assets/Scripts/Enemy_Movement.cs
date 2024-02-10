using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movement;

    public Rigidbody2D ball;
    public float speed = 5.0f;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if (this.ball.velocity.x > 0.0f) {
            if (this.ball.position.y > this.transform.position.y) {
                if (rb.velocity.y < 0) {
                rb.AddForce(Vector2.up * speed * 2f);
                } else {
                rb.AddForce(Vector2.up * speed);
                }
            } else if (this.ball.position.y < this.transform.position.y) {
                if (rb.velocity.y > 0) {
                rb.AddForce(Vector2.down * speed * 2f);
                } else {
                rb.AddForce(Vector2.down * speed);
                }
            }
        } else {
            if (this.transform.position.y > -20.0f)  {
                rb.AddForce(Vector2.down * speed);
            } else if (this.transform.position.y < -20.0f) {
                rb.AddForce(Vector2.up * speed);
            }
        }
        if (rb.velocity.y > 5.0f) {
            rb.velocity = new Vector2(0, 5.0f);
        } else if (rb.velocity.y < -5.0f) {
            rb.velocity = new Vector2(0, -5.0f);
        }
    }
}
