using UnityEngine;

public class NoteHit : MonoBehaviour
{
    public bool isHit;
	
	void Start()
	{
		isHit = false;
	}

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        if (isHit == true)
		{
			Destroy(this.gameObject);
		}
    }
}