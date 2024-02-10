using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Rotate : MonoBehaviour
{
    public float rotateSpeed = 5.0f;

    private float rotationz;
    
    void FixedUpdate()
    {
        rotationz += Time.deltaTime * rotateSpeed * 5;
        transform.rotation = Quaternion.Euler(0, 0, rotationz);
    }
}
