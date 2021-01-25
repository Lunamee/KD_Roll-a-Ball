using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundOption : MonoBehaviour
{
    [SerializeField] GameObject soundOptionPanel;
    [SerializeField] AudioMixerSnapshot gameSoundShot;
    [SerializeField] AudioMixerSnapshot optionSoundShot;
    [SerializeField] AudioMixer audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soundOptionPanel.activeSelf)
        {
            optionSoundShot.TransitionTo(0.01f);
        }
        else
        {
            gameSoundShot.TransitionTo(0.01f);
        }
    }

    public void SetMaster(float volume)
    {
        audioMixer.SetFloat("MasterVol", volume);
    }

    public float masterVolume
    {
        set{ audioMixer.SetFloat("BGMVol", Mathf.Lerp(-80, 0, value)); }
        // audioMixer.SetFloat("BGMVol", volume);
    }

    public void SetSE(float volume)
    {
        audioMixer.SetFloat("SEVol", volume);
    }
}
