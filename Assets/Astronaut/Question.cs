using UnityEngine;

public class Question : MonoBehaviour
{
    private AstronautBehaviour AstronautBehaviour;
    

    [SerializeField] private bool answered;
    [SerializeField] private GameObject optionLayout;
    [SerializeField] private ToggleImage rightOption;
    [SerializeField] private Problem Problem;

    public bool Answered => answered;
    private void Start()
    {
        AstronautBehaviour = FindObjectOfType<AstronautBehaviour>();
    }

    public void ShowQuestion()
    {
        if (!answered)
        {
            optionLayout.SetActive(true);
        }
    }

    public void AnswerQuestion(Answer answer)
    {
        if (!answer.IsRight)
        {
            AstronautBehaviour.TakeDamage();
        }

        rightOption.TurnOn();
        answered = true;
        Problem.MarkQuestionAnswered();
    }
}
