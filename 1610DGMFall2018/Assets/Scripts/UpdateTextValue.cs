using UnityEngine.UI;
using UnityEngine;

public class UpdateTextValue : MonoBehaviour
{
    public Text Value;
    public FloatData Score;

	void Start () {
		
	}
	

	void Update () {
        Value.text = Score.Value.ToString();
	}
}
