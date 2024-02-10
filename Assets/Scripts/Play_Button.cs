using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    [SerializeField] RectTransform fader;
    [SerializeField] private AudioSource clickSoundEffect;

    private void Start() {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, new Vector3(1,1,1), 0);
        LeanTween.scale(fader, Vector3.zero, 2f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            fader.gameObject.SetActive(false);
        });
    }

    public void ButtonClicked() {
        clickSoundEffect.Play();
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1,1,1), 2f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            SceneManager.LoadScene(1);
        });
    }
}
