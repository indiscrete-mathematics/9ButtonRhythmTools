using UnityEngine;
using System.Collections;

public class TextFlash : MonoBehaviour
{
	public GameObject subject;
	private bool TextVisible;
	
    void Start()
    {
		TextVisible = true;
		StartCoroutine(Flash(0.5f));
    }
	
    IEnumerator Flash(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        TextVisible = !TextVisible;
		StartCoroutine(Flash2(0.5f));
    }
	
	IEnumerator Flash2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        TextVisible = !TextVisible;
		StartCoroutine(Flash(0.5f));
    }
	
	void Update()
	{
		if (TextVisible == true) {
			subject.SetActive(true);
		}
		
		else {
			subject.SetActive(false);
		}
	}
}