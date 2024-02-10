using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage_Button : MonoBehaviour
{
    public Game_System gameSystem;
    public Ball_Movement ballMovement;
    [SerializeField] private AudioSource clickSoundEffect;

    public void ButtonClicked() {
        clickSoundEffect.Play();
        if (gameSystem.current_stage < gameSystem.stage) {
            gameSystem.current_stage += 1;
            if (gameSystem.current_stage == gameSystem.stage) {
                gameSystem.point = 0;
            }
            ballMovement.Restart();
        }
    }
}
