using UnityEngine;

public class LongNoteFall : MonoBehaviour
{
    public float speed;
	
	void Start()
	{
		speed = GameObject.Find("NoteManager").GetComponent<NoteSpeed>().fallspeed;
	}

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}