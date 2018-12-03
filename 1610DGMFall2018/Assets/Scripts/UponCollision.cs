using UnityEngine.Events;
using UnityEngine;

public class UponCollision : MonoBehaviour
{
    public UnityEvent Killed;
    public FloatData TotalEnemiesKilled;
    private void Start()
    {
        TotalEnemiesKilled.Value = 0;
    }

    private void OnCollisionEnter()
    {
        Killed.Invoke();
    }
}
