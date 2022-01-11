using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour
{
	public GameObject LightUp;
	public GameObject BackLight;
	public bool Autoplay;
	
	public KeyCode UserKey;
	private bool canPress;
	private bool canUnpress;
	private GameObject enterObject;
	
	void OnTriggerEnter2D(Collider2D other)
    {
		enterObject = other.gameObject;
		if (enterObject.tag == "Note") {
			canPress = true;
		}
		
		if (enterObject.tag == "NoteExit") {
			canUnpress = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
    {
		if (enterObject.tag == "Note" && enterObject != null) {
			canPress = false;
		}
		
		if (enterObject.tag == "NoteExit" && enterObject != null) {
			canUnpress = false;
		}
    }
	
	void Update()
	{
		if (canPress == true && Input.GetKey(UserKey)) {
			//Debug.Log("press");
			GameObject LightTemp = Instantiate(LightUp, transform.position, Quaternion.identity);
			GameObject BackTemp = Instantiate(BackLight, transform.position, Quaternion.identity);
			Destroy(LightTemp, 0.15f);
			Destroy(BackTemp, 0.15f);
			
			if (enterObject.tag == "Note") {
				GameObject.FindWithTag("ScoreManager").GetComponent<ScoreIns>().ScoreCt += 1;
				if(enterObject != null)
				{
					enterObject.GetComponent<NoteHit>().isHit = true;
				}
			}
		}
		
		if (canUnpress == true && Input.GetKeyUp(UserKey)) {
			//Debug.Log("unpress");
			GameObject LightTemp = Instantiate(LightUp, transform.position, Quaternion.identity);
			GameObject BackTemp = Instantiate(BackLight, transform.position, Quaternion.identity);
			Destroy(LightTemp, 0.15f);
			Destroy(BackTemp, 0.15f);
			if (enterObject.tag == "NoteExit") {
				GameObject.FindWithTag("ScoreManager").GetComponent<ScoreIns>().ScoreCt += 1;
				if(enterObject != null)
				{
					enterObject.GetComponent<NoteHit>().isHit = true;
				}
			}
		}
		
	
		if (canPress == true && Autoplay == true) {
			//Debug.Log("press");
			GameObject LightTemp = Instantiate(LightUp, transform.position, Quaternion.identity);
			GameObject BackTemp = Instantiate(BackLight, transform.position, Quaternion.identity);
			Destroy(LightTemp, 0.15f);
			Destroy(BackTemp, 0.15f);
			if (enterObject.tag == "Note") {
				GameObject.FindWithTag("ScoreManager").GetComponent<ScoreIns>().ScoreCt += 1;
				if(enterObject != null)
				{
					enterObject.GetComponent<NoteHit>().isHit = true;
				}
			}
		}
		
		if (canUnpress == true && Autoplay == true) {
			//Debug.Log("unpress");
			GameObject LightTemp = Instantiate(LightUp, transform.position, Quaternion.identity);
			GameObject BackTemp = Instantiate(BackLight, transform.position, Quaternion.identity);
			Destroy(LightTemp, 0.15f);
			Destroy(BackTemp, 0.15f);
			if (enterObject.tag == "NoteExit") {
				GameObject.FindWithTag("ScoreManager").GetComponent<ScoreIns>().ScoreCt += 1;
				if(enterObject != null)
				{
					enterObject.GetComponent<NoteHit>().isHit = true;
				}
			}
		}
		
	}
}