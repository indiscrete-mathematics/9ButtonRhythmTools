using UnityEngine;

public class NoteFallIns : MonoBehaviour 
{
    public GameObject PrefabL1;
	public GameObject PrefabL2;
	public GameObject PrefabL3;
	public GameObject PrefabL4;
	public GameObject PrefabM;
	public GameObject PrefabR1;
	public GameObject PrefabR2;
	public GameObject PrefabR3;
	public GameObject PrefabR4;
	public int ScoreTotal;

    // This script will simply instantiate the Prefab when the game starts.
    //A test
    void Start()
    {
		ScoreTotal = 3;
		
        Invoke("M", 2.0f);
		Invoke("M", 4.0f);
		Invoke("R1", 5.0f);
		Invoke("L1", 5.5f);
    }
	
	
	void L1() {
		Instantiate(PrefabL1,new Vector3(-3f, 0, 0), Quaternion.identity);
	}
	void L2() {
		Instantiate(PrefabL2,new Vector3(-2.25f, 0, 0), Quaternion.identity);
	}
	void L3() {
		Instantiate(PrefabL3,new Vector3(-1.5f, 0, 0), Quaternion.identity);
	}
	void L4() {
		Instantiate(PrefabL4,new Vector3(-0.75f, 0, 0), Quaternion.identity);
	}
	void M() {
		Instantiate(PrefabM,new Vector3(0, 0, 0), Quaternion.identity);
	}
	void R1() {
		Instantiate(PrefabR1,new Vector3(0.75f, 0, 0), Quaternion.identity);
	}
	void R2() {
		Instantiate(PrefabR2,new Vector3(1.5f, 0, 0), Quaternion.identity);
	}
	void R3() {
		Instantiate(PrefabR3,new Vector3(2.25f, 0, 0), Quaternion.identity);
	}
	void R4() {
		Instantiate(PrefabR4,new Vector3(3f, 0, 0), Quaternion.identity);
	}
}
