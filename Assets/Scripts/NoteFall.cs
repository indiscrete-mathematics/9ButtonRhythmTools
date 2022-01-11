using UnityEngine;

public class NoteFall : MonoBehaviour
{
    private float speed;
	
	void Start()
	{
		speed = this.transform.parent.GetComponent<NoteSpeed>().fallspeed;
	}

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}