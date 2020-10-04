using UnityEngine;

public class AstronautBehaviour : MonoBehaviour
{
    [SerializeField] private ToggleImage[] lifes;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject winGameScreen;
    [SerializeField] private Problem[] problems;
    private int lifeCount = 3;

    private void Start()
    {
        foreach (var life in lifes)
        {
            life.TurnOn();
        }
    }

    public void TakeDamage()
    {
        lifeCount -= 1;
        lifes[lifeCount].TurnOff();
        
        if (lifeCount == 0)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void ResolveProblem()
    {
        foreach (var item in problems)
        {
            if (!item.IsSolved)
            {
                return;
            }
        }

        winGameScreen.SetActive(true);
    }
}
