using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] SoundController soundController;
    [SerializeField] List<SoundQuestionData> soundQuestions;
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] Button audioPlayButton; // ���̃T�E���h�Đ��{�^��
    [SerializeField] List<TextMeshProUGUI> ChoicesButtonTexts; // �I�����̃{�^��

    void Start()
    {
        questionText.text = soundQuestions[0].questionText;
        audioPlayButton.onClick.AddListener(OnSoundButtonClick);
        SetButtonText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSoundButtonClick()
    {
        var playSound = soundQuestions[0].audioClip; // �Đ�����T�E���h��clip�擾
        soundController.PlayQuestionSound(playSound);     // �Đ�����
    }

    /// <summary>
    /// �I���{�^���̕\������e�L�X�g��ݒ�
    /// </summary>
    void SetButtonText()
    {
        ChoicesButtonTexts[0].text = soundQuestions[0].choices1;
        ChoicesButtonTexts[1].text = soundQuestions[0].choices2;
        ChoicesButtonTexts[2].text = soundQuestions[0].choices3;
        ChoicesButtonTexts[3].text = soundQuestions[0].choices4;
    }
}
