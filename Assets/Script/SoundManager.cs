using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }
    public AudioSource music;

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void MuteSound() {
        if (music.mute == false)
        {
            music.mute = true;
        }
        else
        {
            music.mute = false;
        }
    }
}
