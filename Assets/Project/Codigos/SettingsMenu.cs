using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{


   [SerializeField] private AudioMixer audioMixer;
   public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }

   
    public void Set30FPS()
    {
        Application.targetFrameRate = 30;

    }

    public void Set60FPS()
    {
        Application.targetFrameRate = 60;
        
    }
}
