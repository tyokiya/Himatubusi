using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    /// <summary>
    /// –â‘è‚Ì‰¹‚ğÄ¶
    /// </summary>
    /// <param name="">Ä¶‚·‚é‰¹‚ÌAudioClip</param>
    public void PlayQuestionSound(AudioClip audioClip)
    {
        audioSource.clip = audioClip; // audioClipƒZƒbƒg
        audioSource.Play();           // Ä¶
    }
}
