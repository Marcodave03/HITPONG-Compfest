using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTopbar_Button : MonoBehaviour
{
    [SerializeField] RectTransform ui;
    [SerializeField] RectTransform button;
    [SerializeField] private AudioSource clickSoundEffect;
    public bool show = true;
    
    public void ButtonClicked() {
        clickSoundEffect.Play();
        if (show == true) {
            show = false;
            LeanTween.moveY(ui, 100, 0.2f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.moveX(button, 0, 0.2f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.rotateAround(button, Vector3.forward, 180, 0.2f).setEase(LeanTweenType.easeInOutQuad);
        }
        else if (show == false) {
            show = true;
            LeanTween.moveY(ui, 0, 0.2f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.moveX(button, 210, 0.2f).setEase(LeanTweenType.easeInOutQuad);
            LeanTween.rotateAround(button, Vector3.forward, 180, 0.2f).setEase(LeanTweenType.easeInOutQuad);
        }
    }
}
