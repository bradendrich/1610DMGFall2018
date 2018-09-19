using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MouseDownBehaviour : MonoBehaviour
{

    public UnityEvent Event;

    private void OnMouseDown()
    {
        Event.Invoke();   
    }
}
