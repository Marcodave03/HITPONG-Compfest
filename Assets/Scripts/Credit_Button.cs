using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_Button : MonoBehaviour
{
    [SerializeField] public GameObject OptionScene;
    [SerializeField] public GameObject CreditsScene;
    [SerializeField] private AudioSource clickSoundEffect;

    public void ButtonClicked() {
        clickSoundEffect.Play();
        OptionScene.SetActive(false);
        CreditsScene.SetActive(true);
    }
}
