using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    /// <summary>
    /// 問題の音を再生
    /// </summary>
    /// <param name="">再生する音のAudioClip</param>
    public void PlayQuestionSound(AudioClip audioClip)
    {
        audioSource.clip = audioClip; // audioClipセット
        audioSource.Play();           // 再生
    }
}
