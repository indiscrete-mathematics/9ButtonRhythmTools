using UnityEngine;
using System.Collections;

public class MenuScroll : MonoBehaviour 
{
	private BoxCollider2D collider_area;
    private float scroll_length; //length of the object to be tiled

    void Start ()
    {
		collider_area = GetComponent<BoxCollider2D>();
    }

	void ScrollUp()
	{
		transform.Translate(0,1f,0);
	}
	
	void ScrollDown()
	{
		transform.Translate(0,-1f,0);
	}

    //Update runs once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ScrollUp();
        }
		
		if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ScrollDown();
        }
		
    }
}