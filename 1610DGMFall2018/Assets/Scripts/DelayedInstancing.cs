using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedInstancing : MonoBehaviour
{
    public GameObject Instance;
    public float Seconds;

	IEnumerator Start ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Seconds);
            Instantiate(Instance, transform.position, transform.rotation);
        }
    }

}
