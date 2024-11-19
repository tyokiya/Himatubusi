using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    /// <summary>
    /// ���̉����Đ�
    /// </summary>
    /// <param name="">�Đ����鉹��AudioClip</param>
    public void PlayQuestionSound(AudioClip audioClip)
    {
        audioSource.clip = audioClip; // audioClip�Z�b�g
        audioSource.Play();           // �Đ�
    }
}
