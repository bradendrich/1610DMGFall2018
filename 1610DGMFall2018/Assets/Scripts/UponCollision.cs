using UnityEngine.Events;
using UnityEngine;

public class UponCollision : MonoBehaviour
{
    public UnityEvent Killed;
    public FloatData TotalEnemiesKilled;
    private void Start()
    {

    }

    private void OnCollisionEnter()
    {
        Killed.Invoke();
    }
}
