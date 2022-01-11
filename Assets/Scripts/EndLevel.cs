using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndLevel : MonoBehaviour
{
	public GameObject OpponentNeutralAnim;
	public GameObject OpponentLoseAnim;
	public GameObject OpponentWinAnim;
	private bool Win;
	private bool Lose;
	
	private int ScoreEnd;
	private int Total;
	
	void Start() {
		Win = false;
		Lose = false;
		GameObject.Find("OpponentLose").SetActive(false);
		GameObject.Find("OpponentWin").SetActive(false);
		GameObject.Find("OpponentNeutral").SetActive(true);
		
		StartCoroutine(End(98.0f));
		StartCoroutine(Reload(103.0f));
	}
	
	void Update() {
		ScoreEnd = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreIns>().ScoreCt;
		Total = GameObject.Find("NoteManagerFall_ins").GetComponent<NoteFallIns_Song01>().ScoreTotal;
		
		if (Win == true) {
			OpponentNeutralAnim.SetActive(false);
			OpponentLoseAnim.SetActive(true);
		}
		
		if (Lose == true) {
			OpponentNeutralAnim.SetActive(false);
			OpponentWinAnim.SetActive(true);
		}
	}
	
	IEnumerator End(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		Debug.Log("end! score =" + ScoreEnd);
		
		if(ScoreEnd >= 232) {
			Debug.Log("win");
			Win = true;
		}
		
		else {
			Debug.Log("lose");
			Lose = true;
		}
	}
	
	IEnumerator Reload(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene("DemoThankYou",LoadSceneMode.Single);
	}
	
}