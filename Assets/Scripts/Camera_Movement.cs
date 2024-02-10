using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public Game_System gameSystem;

    public Transform parent;
    public Transform ball;
    public Vector3 offset;

    private float speed = 0.05f;

    void Update()
    {
        Vector3 desiredPos = new Vector3(ball.position.x, ball.position.y, 0) + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);

        if (transform.position.x > 0.2f + parent.position.x) {
            transform.position = new Vector3(0.2f + parent.position.x, transform.position.y, -1);
        }

        if (transform.position.x < -0.2f + parent.position.x) {
            transform.position = new Vector3(-0.2f + parent.position.x, transform.position.y, -1);
        }
        
        if (transform.position.y > -19.9f) {
            transform.position = new Vector3(transform.position.x, -19.9f, -1);
        }

        if (transform.position.y < -20.1f) {
            transform.position = new Vector3(transform.position.x, -20.1f, -1);
        }
    }
}
