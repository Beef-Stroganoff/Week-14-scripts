//Taylor Burdgess, Charlie Garrido

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TASK 2: Make sure that the power-up and -down sounds work properly. 

public class PowerManager: MonoBehaviour
{
    public AudioClip powerUpSound;
    public AudioClip powerDownSound;
    private AudioSource audioSource;

void Start()
{
    //The AudioSource attached to the Game Object
    audioSource = GetComponent<AudioSource>();

     if (audioSource == null)
{
    Debug.LogError("AudioSource component missing on this GameObject.");
}
}

public void PoweUp()
{
   PlaySound(powerupClip, "Power-Up");
}

public void PowerDown()
{
   PlaySound(powerDownClip, "Power-Down");
}

private void PlaySound(AudioClip clip)
{
    if(clip !=null && audioSource !=null)
    {
        audioSource.PlayOneShot(clip)
    }
    else
    {
      Debug.LogWarning('AudioClip or AudioSource missing.');
    }
}
}