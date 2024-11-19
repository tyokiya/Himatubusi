using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<SoundQuestionData> soundQuestions;
    [SerializeField] TextMeshProUGUI questionText;
    void Start()
    {
        questionText.text = soundQuestions[0].questionText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
