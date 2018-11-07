using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventRepeat : MonoBehaviour
{
    public UnityEvent[] OnRepeat;
    public float Seconds = 2f;
    private int i = 0;
	// Use this for initialization
	IEnumerator Start ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Seconds);

            OnRepeat[i].Invoke();

            if(i < OnRepeat.Length - 1)
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }
	}
}
