using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public bool LightOn;
    public string Password;
    public int A, B, C;

	void Update () {
        if (LightOn)
        {
            print("The light is on.");
        }

        if (Password == "OU812")
        {
            print("The Password is correct");
        }

        if(C == A + B)
        {
            print(C);
        }

        if (Password != "OU812")
        {
            print("The password is not correct");
        }

        if (!LightOn)
        {
            print("The Light is Off");
        }
	}
}
