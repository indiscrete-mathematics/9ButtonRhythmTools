using UnityEngine;
using System;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	bool _isPaused = false;
	public Text _pauseText; 
	
	
	void PauseGame()
	{
		if(_isPaused == true)
        {
            Time.timeScale = 0f;
			_pauseText.text = "Paused";
        }
        else 
        {
            Time.timeScale = 1;
			_pauseText.text = "";
        }
	}

	 void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = !_isPaused;
            PauseGame();
        }
    }
	
}