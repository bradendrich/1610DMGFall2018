using UnityEngine.Events;
using UnityEngine;

public class Instancing : MonoBehaviour
{
    public GameObject instance;
    public FloatData Ammo;
    public UnityEvent Shoot;

    private void Start()
    {
        Ammo.Value = 10;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && Ammo.Value != 0)
        {
            Shoot.Invoke();
            Instantiate(instance, transform.position, Quaternion.identity);
        }
    }
}
