using UnityEngine.Events;
using UnityEngine;

[CreateAssetMenu]
public class ChangeValue : ScriptableObject
{
    public FloatData Data;

    public void AddValueToObj(FloatData data)
    {
        Data.Value += data.Value;
    }

    public void SubtractValueToObj (FloatData data)
    {
        Data.Value -= data.Value;
    }

    public void MultiplyValueToObj (FloatData data)
    {
        Data.Value *= data.Value;
    }

    public void DivideValueToObj (FloatData data)
    {
        Data.Value /= data.Value;
    }
}
