using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_StageView : MonoBehaviour
{
    public Game_System gameSystem;

    public int current_stage_cam = 1;

    private float speed = 30.0f;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPos = new Vector3(gameSystem.current_stage * 30 - 30, -20, -1);
        transform.position = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);
    }
}
