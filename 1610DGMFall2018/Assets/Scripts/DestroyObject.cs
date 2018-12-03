using System.Collections;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public object Other { get; private set; }
    public int Seconds;

    IEnumerator Start ()
    {
        yield return new WaitForSeconds(Seconds);
        Destroy(gameObject);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
