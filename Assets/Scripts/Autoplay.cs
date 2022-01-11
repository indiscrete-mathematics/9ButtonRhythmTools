using UnityEngine;

public class Autoplay : MonoBehaviour {

  void Update() {
	  if (Input.GetKeyDown(KeyCode.Insert)) {
		  this.GetComponent<Bar>().Autoplay = !this.GetComponent<Bar>().Autoplay;
	  }
  }
  
}