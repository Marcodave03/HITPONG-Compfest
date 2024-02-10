using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_MainMenu : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    float[] x = new[]{1.0f,1.0f};
    float[] y = new[]{-1.0f,-0.8f,-0.6f,0.6f,0.8f,1.0f};

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
        int x_random = Random.Range(0, x.Length);
        int y_random = Random.Range(0, y.Length);
        rb.AddForce(new Vector2(x[x_random]*15*speed, y[y_random]*10*speed));
    }
    Vector3 LastVelocity;

    [SerializeField] private AudioSource bounceSoundEffect;

    // Update is called once per frame
    void Update()
    {
        LastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        bounceSoundEffect.Play();
        if (collision.collider.name == "Player" || collision.collider.name == "Enemy") {
            //var speed = LastVelocity.magnitude;
            //float colYExtent = collision.collider.bounds.extents.y;
            //float yOffset = transform.position.y - collision.collider.transform.position.y;
            //float yRatio = yOffset / colYExtent;
            //float bounceAngle = maxBounceAngle * yRatio * Mathf.Deg2Rad;
            //Vector2 bounceDirection = new Vector2(Mathf.Cos(bounceAngle), Mathf.Sin(bounceAngle));
            //Debug.Log(bounceDirection);
            //Debug.Log(Mathf.Max(speed, 0f));
            //rb.velocity = bounceDirection * Mathf.Max(speed, 0f);
            var speed = LastVelocity.magnitude;
            var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed, 0f);
        } else {
            var speed = LastVelocity.magnitude;
            var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
    }
}
