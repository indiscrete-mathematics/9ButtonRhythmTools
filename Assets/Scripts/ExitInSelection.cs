using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitInSelection : MonoBehaviour
{
    void Start()
    {

    }

	 void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
		Debug.Log("Exit");
		SceneManager.LoadScene("StartMenu",LoadSceneMode.Single);
        }
		
    }
	
}