using UnityEngine;
using System;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public int ScoreCt;
	private int Total;
  
  // Use this for initialization
  void Start () {
	  ScoreCt = 0;
	  Total = GameObject.FindGameObjectsWithTag("Note").Length + GameObject.FindGameObjectsWithTag("NoteExit").Length;
	  //Total = GameObject.FindGameObjectsWithTag("Note").Length + GameObject.FindGameObjectsWithTag("NoteL").Length;
  }
  
  // Update is called once per frame
  void Update () {
	scoreText.text = "Score: " + ScoreCt.ToString() + " / " + Total.ToString();
  }
}