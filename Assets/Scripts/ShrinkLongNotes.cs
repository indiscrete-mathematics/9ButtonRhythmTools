using UnityEngine;

public class ShrinkLongNotes : MonoBehaviour
{
	public float unit; //this is how many units the 'long note' takes on the screen

	private float fs;
	Vector3 scale;
	
	private bool hitBar;
	
	void Start()
	{
		hitBar = false;
		fs = GameObject.Find("NoteManager").GetComponent<NoteSpeed>().fallspeed;
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
		if(other.tag == "Bar")
		{
			hitBar = true;
			Debug.Log("long note hit bar");
			gameObject.GetComponent<LongNoteFall>().speed = 0;
		}
	}

    void Update()
    {
		if(hitBar ==  true)
		{
			scale = transform.localScale;
 
			scale.y -= Time.deltaTime * (fs/unit);
 
			transform.localScale = scale;
		}
		
		if(transform.localScale.y <= 0 && this.gameObject != null)
		{
			Destroy(this.gameObject);
		}
    }
}