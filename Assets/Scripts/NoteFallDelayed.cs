using UnityEngine;
using System.Collections;

public class NoteFallDelayed : MonoBehaviour
{
	public float delay;
    private float speed;
	private bool startFalling;
	
	void Start()
	{
		speed = this.transform.parent.GetComponent<NoteSpeed>().fallspeed;
		startFalling = false;

		StartCoroutine(Activate());
	}
	
	IEnumerator  Activate() {
		yield return new WaitForSeconds(delay);
		startFalling = true;
		yield return null;
	}

    void Update()
    {
		if(startFalling == true) {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
		}
    }
}