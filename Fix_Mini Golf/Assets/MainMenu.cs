using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance { get; set; }
    [SerializeField] string BGMVolume = "BGMVolume";
    [SerializeField] string SFXVolume = "SFXVolume";
    public AudioSource BGM;
    // public AudioSource SFX1;
    // public AudioSource SFX2;
    // public AudioSource SFX3;
    // public AudioSource SFX4;
    // [SerializeField] AudioMixer mixer;
    [SerializeField] float MusicVolume = 1f;
    [SerializeField] float SFXVol = 1f;

    private void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat(BGMVolume, 0);
        SFXVol = PlayerPrefs.GetFloat(SFXVolume, 0);
        Debug.Log(MusicVolume);
        BGM.volume = MusicVolume;
        BGM.Play();


        // float BGMValue = PlayerPrefs.GetFloat(BGMVolume);
        // float SFXvalue = PlayerPrefs.GetFloat(SFXVolume);
        // SFX1.volume = PlayerPrefs.GetFloat(BGMVolume, 0);
        // mixer.SetFloat(BGMVolume, BGMValue);
        // mixer.SetFloat(SFXVolume, SFXvalue);
    }
}
