using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject
{
    public FloatData Data;

    public void OnPowerUP (FloatData outsideData)
    {
        outsideData.Value += Data.Value;
    }
}
