using UnityEngine;

public class SelectionMenuImage : MonoBehaviour
{
	public void Up()
	{
		transform.Translate(0, 1f, 0);
	}
	
	public void Down()
	{
		transform.Translate(0, -1f, 0);
	}
		
}