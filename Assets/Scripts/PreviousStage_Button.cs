using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousStage_Button : MonoBehaviour
{
    public Game_System gameSystem;
    public Ball_Movement ballMovement;
    [SerializeField] private AudioSource clickSoundEffect;

    public void ButtonClicked() {
        clickSoundEffect.Play();
        if (gameSystem.current_stage > 1) {
            gameSystem.current_stage -= 1;
            gameSystem.point = 10;
            ballMovement.Restart();
        }
    }
}
