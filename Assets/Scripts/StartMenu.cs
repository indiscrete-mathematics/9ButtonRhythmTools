using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour
{
	public AudioSource StartupSound;
	
    void Start()
    {

    }
	
	void Update()
	{
		if(Input.GetKey(KeyCode.Return)) {
		Debug.Log("Start");
		StartupSound.Play();
		StartCoroutine(StartGame());
		}
	}
	
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene("SelectionScreen",LoadSceneMode.Single);
    }
}