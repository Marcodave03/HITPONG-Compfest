using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Bounce : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;

    [SerializeField] private AudioSource bounceSoundEffect;

    //[SerializeField] private float maxBounceAngle = 45f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
