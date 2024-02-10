using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Goal : MonoBehaviour
{
    public Game_System gameSystem;
    public Ball_Movement ballMovement;

    [SerializeField] private AudioSource winSoundEffect;
    [SerializeField] private AudioSource loseSoundEffect;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Lose") {
            loseSoundEffect.Play();
            if (gameSystem.point > 0 && gameSystem.point != 10) {
                gameSystem.point -= 1;
            }
            ballMovement.Restart();
        } else if (other.gameObject.name == "Win") {
            winSoundEffect.Play();
            gameSystem.point += 1;
            if (gameSystem.point == 5) {
                gameSystem.stage += 1;
                gameSystem.point = 0;
                gameSystem.current_stage = gameSystem.stage;
            }
            ballMovement.Restart();
        }
    }
}
