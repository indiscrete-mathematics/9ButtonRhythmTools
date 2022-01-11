using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayAudio : MonoBehaviour
{
	public AudioSource EndSound;
	public float delaySound;
	
    void Start()
    {
		EndSound.PlayDelayed(delaySound);
    }
	
}