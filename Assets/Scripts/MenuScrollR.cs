using UnityEngine;
using System.Collections;

public class MenuScrollR : MonoBehaviour 
{
    
    private BoxCollider2D groundCollider;
    private float groundlLength;

    //Awake is called before Start.
    void Start ()
    {
        //Get and store a reference to the collider2D attached to Ground.
        groundCollider = GetComponent<BoxCollider2D> ();
        //Store the size of the collider along the y axis (its length in units).
        groundlLength = groundCollider.size.y;
    }

    //Update runs once per frame
    void Update()
    {
        //Check if the difference along the x axis between the main Camera and the position of the object this is attached to is greater than groundlLength.
        if (transform.position.y < -groundlLength)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground ();
        }
		
		if (transform.position.y > groundlLength)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackgroundN ();
        }
    }

    //Moves the object this script is attached to right in order to create our looping background effect.
    void RepositionBackground()
    {
        //This is how far to the right we will move our background object, in this case, twice its length. This will position it directly to the right of the currently visible background object.
        Vector2 groundOffSet = new Vector2(0, groundlLength * 2f);

        //Move this object from it's position offscreen to the new position off-camera in front of the player.
        transform.position = (Vector2) transform.position + groundOffSet;
    }
	
	void RepositionBackgroundN()
    {
        //This is how far to the right we will move our background object, in this case, twice its length. This will position it directly to the right of the currently visible background object.
        Vector2 groundOffSet = new Vector2(0, -groundlLength * 2f);

        //Move this object from it's position offscreen to the new position off-camera in front of the player.
        transform.position = (Vector2) transform.position + groundOffSet;
    }
}