using UnityEngine;

public class DelayCalculator : MonoBehaviour
{
    public float DelayValue;
    public float PerwordValue = 0.05f;

    [SerializeField] private float SlowValue = 4;
    [SerializeField] private float MediumValue = 2.5f;
    [SerializeField] private float FastValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "slow":
                DelayValue = SlowValue;
                break;
            case "medium":
                DelayValue = MediumValue;
                break;
            case "fast":
                DelayValue = FastValue;
                break;
            case "none":
                DelayValue = 0;
                break;
        }   
    }
}
