using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparisons : MonoBehaviour
{
    public FloatData DefaultValue;

    public void OnComparisonsValue(FloatData data)
    {
        if (DefaultValue.Value == data.Value)
        {
            print("You may pass");
        }
        else if (DefaultValue.Value < data.Value)
        {
            print("You may skip this area");
        }
        else
        {
            print("You Shall not pass!!!");
        }
    }
}
