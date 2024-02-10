using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditBack_Button : MonoBehaviour
{
    [SerializeField] public GameObject OptionScene;
    [SerializeField] public GameObject CreditsScene;
    [SerializeField] private AudioSource clickSoundEffect;

    public void ButtonClicked() {
        clickSoundEffect.Play();
        OptionScene.SetActive(true);
        CreditsScene.SetActive(false);
    }
}
