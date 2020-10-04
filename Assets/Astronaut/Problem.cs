using UnityEngine;

public class Problem : MonoBehaviour
{
    [SerializeField] private Question[] questions;
    [SerializeField] private GameObject problemIcon;


    private bool isSolved;
    public bool IsSolved => isSolved;
    private AstronautBehaviour AstronautBehaviour;

    private void Start()
    {
        AstronautBehaviour = FindObjectOfType<AstronautBehaviour>();
    }

    public void MarkQuestionAnswered()
    {
        foreach (var item in questions)
        {
            if (!item.Answered)
            {
                return;
            }
        }

        problemIcon.SetActive(false);
        isSolved = true;

        AstronautBehaviour.ResolveProblem();
    }
}
