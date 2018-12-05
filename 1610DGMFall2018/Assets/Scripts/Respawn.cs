using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject ActivePlayer;
    public GameObject PlayerDefault;
    public Transform SpawnPoint;
    public FloatData Lives;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ActivePlayer == null)
        {
            Lives.Value = Lives.Value - 1;
        }
        if (ActivePlayer == null && Lives.Value > 0)
        {
            //TODO MAKE IT RESPAWN INSTEAD OF RELOAD
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    } 
}
