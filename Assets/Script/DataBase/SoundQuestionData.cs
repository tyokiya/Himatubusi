using UnityEngine;

[CreateAssetMenu(fileName = "QuestionDataBase", menuName = "�������f�[�^�쐬")] 

public class SoundQuestionData : ScriptableObject
{
    [SerializeField] public AudioClip audioClip;
    [SerializeField] public string questionText;
    [SerializeField] public string choices;
    [SerializeField] public string choices2;
    [SerializeField] public string choices3;
    [SerializeField] public string choices4;
    [SerializeField] public int anserNum;
    [SerializeField] public string message;
}
