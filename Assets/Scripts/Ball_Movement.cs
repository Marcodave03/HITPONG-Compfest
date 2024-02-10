using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public Game_System gameSystem;

    Rigidbody2D rb;
    public float speed;
    public float speedmultiplier = 1f;
    
    float[] x = new[]{1.0f,1.0f};
    float[] y = new[]{-1.0f,-0.8f,-0.6f,0.6f,0.8f,1.0f};

    public void Restart() {
        speedmultiplier = 1f;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(gameSystem.current_stage * 30 - 37, -20);
        int x_random = Random.Range(0, x.Length);
        int y_random = Random.Range(0, y.Length);
        rb.AddForce(new Vector2(x[x_random]*15*speed, y[y_random]*10*speed));
    }

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    private void FixedUpdate() {
        rb.AddForce(new Vector2(rb.velocity.x * 1.005f * speedmultiplier * Time.deltaTime, rb.velocity.y * 1.005f * speedmultiplier * Time.deltaTime));
    }
}
