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
    [SerializeField] Button audioPlayButton; // 問題のサウンド再生ボタン
    [SerializeField] List<TextMeshProUGUI> ChoicesButtonTexts; // 選択肢のボタン

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
        var playSound = soundQuestions[0].audioClip; // 再生するサウンドのclip取得
        soundController.PlayQuestionSound(playSound);     // 再生命令
    }

    /// <summary>
    /// 選択ボタンの表示するテキストを設定
    /// </summary>
    void SetButtonText()
    {
        ChoicesButtonTexts[0].text = soundQuestions[0].choices1;
        ChoicesButtonTexts[1].text = soundQuestions[0].choices2;
        ChoicesButtonTexts[2].text = soundQuestions[0].choices3;
        ChoicesButtonTexts[3].text = soundQuestions[0].choices4;
    }
}
