using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sync : MonoBehaviour
{
    public Rigidbody2D mainPlayer;

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, this.mainPlayer.position.y);
    }
}
