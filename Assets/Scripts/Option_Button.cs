using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Button : MonoBehaviour
{
    [SerializeField] public GameObject MainScene;
    [SerializeField] public GameObject OptionScene;
    [SerializeField] private AudioSource clickSoundEffect;

    public void ButtonClicked() {
        clickSoundEffect.Play();
        MainScene.SetActive(false);
        OptionScene.SetActive(true);
    }
}
