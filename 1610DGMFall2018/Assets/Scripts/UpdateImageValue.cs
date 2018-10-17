using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpdateImageValue : MonoBehaviour
{
    public FloatData Data;
    private Image image;

	void Start ()
    {
        image = GetComponent<Image>();
	}
	
	void Update ()
    {
        image.fillAmount = Data.Value;
	}
}
