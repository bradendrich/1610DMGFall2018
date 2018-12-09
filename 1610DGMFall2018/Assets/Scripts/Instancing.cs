using UnityEngine.Events;
using UnityEngine;

public class Instancing : SideScroller
{
    public GameObject Instance;
    public FloatData Ammo;
    public UnityEvent Shoot;

    private void Start()
    {
        Ammo.Value = 10;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && Ammo.Value != 0 /*&& Flipped != true*/)
        {
            Shoot.Invoke();
            Instantiate(Instance, transform.position, Quaternion.identity);
        }
        /*else
        {
            Shoot.Invoke();
            Instantiate(Instance);
            GetComponent<Rigidbody>(ConstantForce.Instantiate(Instance);
        }*/
    }
}
