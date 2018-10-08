using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public object Other { get; private set; }

    IEnumerator Start ()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
