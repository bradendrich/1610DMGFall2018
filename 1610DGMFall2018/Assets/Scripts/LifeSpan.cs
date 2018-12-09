using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour {

    public object Other { get; private set; }
    public int Seconds;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(Seconds);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
