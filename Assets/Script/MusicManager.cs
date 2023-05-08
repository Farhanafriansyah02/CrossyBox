using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Toggle buttonMute;
    public Slider sliderVolume;

    public void SliderVolume()
    {
        SoundManager.Instance.music.volume = sliderVolume.value;
    }

    public void ButtonMute() {
        if(SoundManager.Instance.music == true)
        {
            SoundManager.Instance.MuteSound();
        }
        else
        {
            SoundManager.Instance.MuteSound();
        }
    }
}