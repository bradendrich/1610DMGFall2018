using UnityEngine.Events;
using UnityEngine;

[CreateAssetMenu]
public class AddValue : ScriptableObject
{
    public FloatData ValueObj;
    public FloatData MaxValue;
    public FloatData MinValue;

    public UnityEvent EventMax;
    public UnityEvent EventMin;

    public void AddValueToObj(FloatData data)
    {
        ValueObj.Value += data.Value;

        if(ValueObj.Value <= 0)
        {
            EventMin.Invoke();
        }

        if (ValueObj.Value <= MinValue.Value)
        {
            EventMin.Invoke();
        }
    }
}
