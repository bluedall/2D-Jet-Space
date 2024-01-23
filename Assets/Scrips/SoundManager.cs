using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //[SerializeField] AudioClip Clip;
    [SerializeField] AudioSource Source;

   public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip clip)
    {

        Source.PlayOneShot(clip);
    }
}
