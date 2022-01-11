using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreIns : MonoBehaviour {
	public Text scoreText;
	public int ScoreCt;
	private int Total;
  
  // Use this for initialization
  void Start () {
	  ScoreCt = 0;
	  Total = GameObject.Find("NoteManagerFall_ins").GetComponent<NoteFallIns_Song01>().ScoreTotal;
  }
  
  // Update is called once per frame
  void Update () {
	scoreText.text = "Score: " + ScoreCt.ToString() + " / " + Total.ToString();
  }
}