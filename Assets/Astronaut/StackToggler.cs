using UnityEngine;

public class StackToggler : MonoBehaviour
{
    [SerializeField] private GameObject[] images;

    public void TurnOff()
    {
        foreach (var item in images)
        {
            item.SetActive(false);
        }
    }
}
