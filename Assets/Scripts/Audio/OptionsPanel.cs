using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour
{
    [SerializeField] private AudioManager audioManager;

    [SerializeField] private Toggle muteToggle;

    [SerializeField] private Slider bgmSlider;
    [SerializeField] private Slider sfxSlider;

    [SerializeField] private TMP_Text bgmVolText;
    [SerializeField] private TMP_Text sfxVolText;

    private void OnEnable()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
        sfxSlider.value = audioManager.SfxVolume;
        SetBgmVolText(bgmSlider.value);
        SetSfxVolText(sfxSlider.value);
    }

    public void SetBgmVolText(float value)
    {
        bgmVolText.text = Mathf.RoundToInt(value * 100).ToString();
    }

    public void SetSfxVolText(float value)
    {
       sfxVolText.text = Mathf.RoundToInt(value * 100).ToString();
    }
}
