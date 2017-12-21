using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySfx : MonoBehaviour
{
    public AudioSource soundFX;
    public AudioClip buttonClick;

    public void PlayButtonSound()
    {
        soundFX.PlayOneShot(buttonClick);
    }
}
