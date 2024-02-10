using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_System : MonoBehaviour
{
    public int stage = 1;
    public int point = 0;
    public int current_stage = 1;

    public Text topText;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        GameSystemData data = SaveSystem.LoadPlayer();

        stage = data.stage;
        current_stage = data.current_stage;
        if (current_stage < stage) {
            point = 10;
        }
    }

    void Start()
    {
        LoadPlayer();
    }

    void Update() {
        topText.text = "STAGE " + current_stage.ToString();
        if (point == 0) {
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
        } else if (point == 1) {
            point1.SetActive(true);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
        } else if (point == 2) {
            point1.SetActive(true);
            point2.SetActive(true);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
        } else if (point == 3) {
            point1.SetActive(true);
            point2.SetActive(true);
            point3.SetActive(true);
            point4.SetActive(false);
            point5.SetActive(false);
        } else if (point == 4) {
            point1.SetActive(true);
            point2.SetActive(true);
            point3.SetActive(true);
            point4.SetActive(true);
            point5.SetActive(false);
        } else if (point == 10) {
            point1.SetActive(true);
            point2.SetActive(true);
            point3.SetActive(true);
            point4.SetActive(true);
            point5.SetActive(true);
        }
        SavePlayer();
    }
}
