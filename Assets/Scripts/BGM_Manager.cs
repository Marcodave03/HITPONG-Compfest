using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Manager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    void Start() {
        if(!PlayerPrefs.HasKey("BGMVolume")) {
            PlayerPrefs.SetFloat("BGMVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume() {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load() {
        volumeSlider.value = PlayerPrefs.GetFloat("BGMVolume");
    }

    private void Save() {
        PlayerPrefs.SetFloat("BGMVolume", volumeSlider.value);
    }
}
