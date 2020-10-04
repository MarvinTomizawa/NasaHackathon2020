using UnityEngine;

public class ToggleImage : MonoBehaviour
{
    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;

    private bool isOn = false;

    public void TurnOn()
    {
        isOn = true;
        on.SetActive(true);
        off.SetActive(false);
    }

    public void TurnOff()
    {
        isOn = false;
        on.SetActive(false);
        off.SetActive(true);
    }

    public void Toggle()
    {
        isOn = !isOn;
        on.SetActive(isOn);
        off.SetActive(!isOn);
    }

}
