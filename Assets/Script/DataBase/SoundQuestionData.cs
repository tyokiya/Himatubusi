using UnityEngine;

[CreateAssetMenu(fileName = "QuestionDataBase", menuName = "音声問題データ作成")] 

public class SoundQuestionData : ScriptableObject
{
    [SerializeField] public AudioClip audioClip;
    [SerializeField] public string questionText;
    [SerializeField] public string choices1;
    [SerializeField] public string choices2;
    [SerializeField] public string choices3;
    [SerializeField] public string choices4;
    [SerializeField] public int anserNum;
    [SerializeField] public string message;
}
