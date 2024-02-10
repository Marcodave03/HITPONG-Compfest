using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Speeding : MonoBehaviour
{
    public Ball_Movement ballMovement;

    // Rainbow color change
    Renderer rend;
    [SerializeField] [Range(0f, 10f)] float lerpTime;
    [SerializeField] Color[] myColors;
    int colorIndex = 0;
    float t = 0f;
    int len;

    void Start() {
        // Rainbow color change
        rend = GetComponent<Renderer>();
        len = myColors.Length;
    }

    void Update() {
        // Rainbow color change
        rend.material.color = Color.Lerp(rend.material.color, myColors[colorIndex], lerpTime*Time.deltaTime);
        t = Mathf.Lerp(t,1f,lerpTime*Time.deltaTime);
        if (t>0.9f) {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Ball") {
            ballMovement.speedmultiplier += 1;
        }
    }
}
