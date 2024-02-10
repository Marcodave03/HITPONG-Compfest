using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Color : MonoBehaviour
{
    public Game_System gameSystem;
    private Renderer rend;

    private void Start() {
        rend = GetComponent<Renderer>();
    }
    
    private void Update() {

        if (gameSystem.current_stage >= 1 && gameSystem.current_stage <= 5) {
            rend.material.color = Color.white;
        }
        
        if (gameSystem.current_stage >= 6 && gameSystem.current_stage <= 10) {
            rend.material.color = Color.black;
        }
        
        if (gameSystem.current_stage >= 11 && gameSystem.current_stage <= 15) {
            rend.material.color = new Color(1f, 0f, 1f, 1f);
        }
        
        if (gameSystem.current_stage >= 16 && gameSystem.current_stage <= 20) {
            rend.material.color = new Color(1f, 181/255f, 83/255f, 1f);
        }
        
        if (gameSystem.current_stage >= 21 && gameSystem.current_stage <= 25) {
            rend.material.color = new Color(0f, 1f, 1f, 1f);
        }
            
    }
}
