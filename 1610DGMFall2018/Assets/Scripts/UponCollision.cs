using UnityEngine.Events;
using UnityEngine;

public class UponCollision : MonoBehaviour
{
    public UnityEvent Death;

    private void OnCollisionEnter()
    {
        Death.Invoke();
    }
}
