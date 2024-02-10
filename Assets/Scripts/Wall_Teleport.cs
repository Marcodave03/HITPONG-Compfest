using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Teleport : MonoBehaviour
{
    public Wall_Teleport wallTeleportDes;

    // Rainbow color change
    Renderer rend;
    [SerializeField] [Range(0f, 10f)] float lerpTime;
    [SerializeField] Color[] myColors;
    int colorIndex = 0;
    float t = 0f;
    int len;

    public bool activate = true;

    // Teleport
    public Transform destination;
    public float distance = 0.2f;
    [SerializeField] private AudioSource tpSoundEffect;

    void Start() {
        // Rainbow color change
        rend = GetComponent<Renderer>();
        len = myColors.Length;

        // Teleport
        tpSoundEffect = GetComponent<AudioSource>();
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

    // Teleport
    private void OnTriggerEnter2D(Collider2D other) {
        if (Vector2.Distance(transform.position, other.transform.position) > distance && activate == true) {
            wallTeleportDes.activate = false;
            activate = false;
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            tpSoundEffect.Play();
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        activate = true;
        wallTeleportDes.activate = true;
    }
}
