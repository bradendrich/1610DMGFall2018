using UnityEngine.Events;
using UnityEngine;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent Enable;
    public UnityEvent Trigger;

    private void OnEnable()
    {
        Enable.Invoke();
    }

    private void OnTriggerEnter()
    {
        Trigger.Invoke();
    }
}
