using UnityEngine;

public class Delay_Audio : MonoBehaviour 
{
	public AudioSource Song;
	public float delay;
	
    void Start()
    {	
	Song.PlayDelayed(delay);
	}
}