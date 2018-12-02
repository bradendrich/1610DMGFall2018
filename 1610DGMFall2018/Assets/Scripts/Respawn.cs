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
        if (ActivePlayer == null && Lives.Value > 0)
        {
            //TODO MAKE IT RESPAWN INSTEAD OF RELOAD
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    } 
}


//Instantiate(PlayerDefault, SpawnPoint);
// Player.transform.position = SpawnPoint.transform.position;
//Instead of making the player respawn, I have made it so that the scene will just reload
//I would still like to learn how to make the character just respawn there instead of reloading
