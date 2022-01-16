using UnityEngine;

// Mr. T/ Cyndi Lauper - Goonies 'R' Good Enough (Pop'n Music 10)
//This is the song used in the Burstin' Tunes demo

public class NoteFallIns_Song01 : MonoBehaviour 
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
    void Start()
    {
		ScoreTotal = 386;
		
		Invoke("L1", 3.4f); 
		Invoke("R4", 3.4f); //+3.4
		Invoke("R3", 3.8f);
		Invoke("L1", 4.0f);
		Invoke("L3", 4.2f);
		Invoke("M", 4.4f);
		Invoke("R1", 4.6f);
		Invoke("R3", 4.8f);
		Invoke("L3", 5.2f);
		Invoke("L1", 5.3f);
		Invoke("R3", 5.4f);
		Invoke("L1", 5.6f);
		Invoke("L2", 5.8f);
		Invoke("L4", 6.0f);
		Invoke("M", 6.2f);
		Invoke("R3", 6.4f);
		Invoke("L1", 6.6f);
		Invoke("R3", 7.0f);
		Invoke("L1", 7.2f);
		Invoke("L3", 7.4f);
		Invoke("M", 7.6f);
		Invoke("R1", 7.8f);
		Invoke("R3", 8.0f);
		Invoke("L4", 8.4f);
		Invoke("L2", 8.5f);
		Invoke("R1", 8.6f);
		Invoke("L1", 8.8f);
		Invoke("L3", 9.0f);
		Invoke("M", 9.2f);
		Invoke("R2", 9.4f);
		Invoke("L2", 9.7f);
		Invoke("R1", 9.8f);
		Invoke("R3", 9.8f);
		Invoke("R2", 10.4f);
		Invoke("R3", 10.5f);
		Invoke("R4", 10.6f);
		Invoke("M", 11.0f);
		Invoke("L1", 11.2f); //L1 chain pattern
		Invoke("L1", 11.6f);
		Invoke("L1", 12.0f);
		Invoke("L1", 12.2f);
		Invoke("L3", 12.6f);
		Invoke("M", 12.6f);
		Invoke("R3", 12.9f);
		Invoke("L1", 13.0f); //13.0
		Invoke("R1", 13.0f); //13.0
		Invoke("L1", 13.6f); //13.6
		Invoke("L4", 13.6f); //13.6
		Invoke("L1", 13.8f);
		Invoke("L3", 14.2f); //14.2
		Invoke("R1", 14.2f); //14.2
		Invoke("L1", 14.4f); //L1 chain pattern
		Invoke("L1", 14.8f);
		Invoke("L1", 15.2f);
		Invoke("L1", 15.4f);
		Invoke("M", 15.6f); //red-green
		Invoke("R2", 15.6f);
		Invoke("M", 15.8f);
		Invoke("L3", 15.8f);
		Invoke("R4", 16.2f);
		Invoke("M", 16.6f);
		Invoke("L2", 17.0f);
		Invoke("M", 17.2f);
		Invoke("L2", 17.6f);
		Invoke("R3", 17.8f);
		Invoke("R2", 18.2f);
		Invoke("M", 18.6f);
		Invoke("L3", 19.0f);
		Invoke("M", 19.2f);
		Invoke("R2", 19.3f);
		Invoke("L3", 20.6f);
		Invoke("M", 20.8f);
		Invoke("L1", 21.2f); //L1-yellow
		Invoke("L1", 21.4f);
		Invoke("R3", 21.4f);
		Invoke("L1", 21.6f);
		Invoke("L2", 21.8f);
		Invoke("L3", 22.0f);
		Invoke("R3", 22.0f);
		Invoke("L3", 22.2f);
		Invoke("R3", 22.2f);
		Invoke("L3", 22.4f); //Red/ M chain
		Invoke("R4", 22.6f);
		Invoke("M", 23.0f);
		Invoke("M", 23.2f);
		Invoke("M", 23.4f);
		Invoke("M", 23.8f);
		Invoke("R2", 24.2f);
		Invoke("R1", 24.6f);
		Invoke("M", 25.0f);
		Invoke("L3", 25.4f);
		Invoke("L3", 26.0f);
		Invoke("L3", 26.2f);
		Invoke("L3", 26.4f);
		Invoke("M", 26.6f);
		Invoke("R2", 26.8f);
		Invoke("L1", 27.2f);
		Invoke("L1", 27.6f);
		Invoke("L3", 27.8f);
		Invoke("M", 28.2f);
		Invoke("R3", 28.6f);
		Invoke("L1", 29.0f);
		Invoke("R4", 29.4f);
		Invoke("R3", 29.8f);
		Invoke("R2", 30.2f); //30.2
		Invoke("R4", 30.2f); //30.2
		Invoke("R1", 30.6f);
		Invoke("R3", 30.6f);
		Invoke("M", 31.0f); //red-green swapping 31
		Invoke("R2", 31.0f); //31
		Invoke("L4", 31.4f); //31.4
		Invoke("R1", 31.4f); //31.4
		Invoke("M", 31.6f); //31.6
		Invoke("R2", 31.6f); //
		Invoke("R2", 32.6f);
		Invoke("R1", 33.0f);
		Invoke("M", 33.4f); //red-green swapping
		Invoke("R2", 33.4f);
		Invoke("L4", 33.8f); //
		Invoke("R1", 33.8f); //
		Invoke("L3", 34.2f);
		Invoke("M", 34.2f);
		Invoke("L2", 34.6f);
		Invoke("L4", 34.6f);
		Invoke("L3", 34.8f);
		Invoke("M", 34.8f);
		Invoke("L1", 35.4f);
		Invoke("R4", 35.8f);
		Invoke("R3", 36.2f);
		Invoke("R2", 36.6f);
		Invoke("R4", 36.6f);
		Invoke("R1", 37.0f);
		Invoke("R3", 37.0f);
		Invoke("M", 37.4f);
		Invoke("R2", 37.4f);
		Invoke("R1", 37.6f);
		Invoke("R4", 37.6f);
		Invoke("R1", 38.0f);
		Invoke("R4", 38.0f);
		Invoke("M", 38.2f);
		Invoke("R3", 38.2f);
		Invoke("L4", 38.4f);
		Invoke("R2", 38.4f);
		Invoke("L1", 38.6f);
		Invoke("R3", 39.0f);
		Invoke("R1", 39.3f);
		Invoke("R3", 39.4f);
		Invoke("L3", 39.8f);
		Invoke("L1", 40.1f);
		Invoke("L3", 40.2f);
		Invoke("R2", 40.6f);
		Invoke("R2", 41.0f);
		Invoke("R2", 41.4f);
		Invoke("R3", 42.2f);
		Invoke("R1", 42.5f);
		Invoke("R3", 42.6f);
		Invoke("R2", 42.8f);
		Invoke("M", 43.0f);
		Invoke("L3", 43.2f);
		Invoke("L2", 43.3f);
		Invoke("L1", 43.4f);
		Invoke("R1", 43.8f);
		Invoke("R1", 44.2f);
		Invoke("R2", 44.8f);
		Invoke("R4", 44.9f);
		Invoke("M", 45.6f);
		Invoke("M", 45.8f);
		Invoke("L3", 47.4f);
		Invoke("M", 47.6f); //red-yellow three-half set
		Invoke("R3", 47.6f);
		Invoke("M", 47.8f);
		Invoke("R3", 47.8f);
		Invoke("M", 48.0f);
		Invoke("L1", 48.2f);
		Invoke("M", 48.4f);
		Invoke("R4", 48.6f);
		Invoke("R1", 48.8f);
		Invoke("R3", 49.0f);
		Invoke("L1", 49.2f);
		Invoke("L2", 49.4f); //
		Invoke("R2", 49.4f); //
		Invoke("L3", 49.6f);
		Invoke("M", 49.8f); //
		Invoke("R4", 49.8f); //
		Invoke("R3", 50.1f);
		Invoke("R2", 50.4f);
		Invoke("L4", 50.6f);
		Invoke("R1", 50.6f);
		Invoke("M", 51.0f);
		Invoke("R2", 51.1f);
		Invoke("L2", 51.3f);
		Invoke("L1", 51.4f);
		Invoke("R4", 51.4f);
		Invoke("R3", 51.8f);
		Invoke("L1", 52.0f);
		Invoke("L3", 52.2f);
		Invoke("M", 52.4f);
		Invoke("R1", 52.6f);
		Invoke("R3", 52.8f);
		Invoke("L3", 53.2f);
		Invoke("L1", 53.3f);
		Invoke("R3", 53.4f);
		Invoke("L1", 53.6f);
		Invoke("L2", 53.8f);
		Invoke("L4", 54.0f);
		Invoke("M", 54.2f);
		Invoke("R2", 54.4f);
		Invoke("R4", 54.5f);
		Invoke("L1", 54.6f);
		Invoke("R3", 55.0f);
		Invoke("L1", 55.2f);
		Invoke("L3", 55.4f);
		Invoke("M", 55.6f);
		Invoke("R1", 55.8f);
		Invoke("R3", 56.0f);
		Invoke("L3", 56.4f);
		Invoke("L1", 56.5f);
		Invoke("R3", 56.6f);
		Invoke("L1", 56.8f);
		Invoke("L2", 57.0f);
		Invoke("L4", 57.2f);
		Invoke("M", 57.4f);
		Invoke("R2", 57.6f);
		Invoke("L2", 57.7f);
		Invoke("L1", 57.8f);
		Invoke("M", 57.8f);
		Invoke("R1", 58.4f);
		Invoke("R3", 58.5f);
		Invoke("R4", 58.6f);
		Invoke("L3", 59.0f);
		Invoke("L1", 59.2f);
		Invoke("L1", 60.2f);
		Invoke("R1", 60.4f);
		Invoke("L1", 60.6f); //
		Invoke("L4", 60.6f); //
		Invoke("L2", 60.9f);
		Invoke("L1", 61.0f);
		Invoke("R2", 61.0f);
		Invoke("L1", 61.6f);
		Invoke("M", 61.6f);
		Invoke("L1", 61.8f);
		Invoke("L4", 62.2f);
		Invoke("R2", 62.2f);
		Invoke("L1", 62.4f);
		Invoke("L1", 63.4f); //
		Invoke("L3", 63.4f); //
		Invoke("R3", 63.6f);
		Invoke("R3", 63.8f); ///
		Invoke("L1", 63.8f); ///
		Invoke("L3", 63.8f); ///
		Invoke("L1", 64.2f);
		Invoke("M", 64.2f);
		Invoke("R4", 64.6f);
		Invoke("R3", 65.0f);
		Invoke("R2", 65.4f); //65.4
		Invoke("R4", 65.4f); //65.4
		Invoke("R1", 65.8f);
		Invoke("R3", 65.8f);
		Invoke("M", 66.2f);
		Invoke("R2", 66.2f);
		Invoke("L4", 66.6f); //66.6
		Invoke("R1", 66.6f); //66.6
		Invoke("M", 66.8f); //
		Invoke("R2", 66.8f); //
		Invoke("L1", 67.2f);
		Invoke("L1", 67.4f);
		Invoke("R2", 67.8f);
		Invoke("R1", 68.2f);
		Invoke("M", 68.6f); //68.6
		Invoke("R2", 68.6f);
		Invoke("L4", 69.0f); 
		Invoke("R1", 69.0f);
		Invoke("L3", 69.4f);
		Invoke("M", 69.4f);
		Invoke("L2", 69.8f);
		Invoke("L4", 69.8f);
		Invoke("L3", 70.0f);
		Invoke("M", 70.0f);
		Invoke("L1", 70.6f);
		Invoke("R4", 71.0f);
		Invoke("R3", 71.4f);
		Invoke("R2", 71.8f);
		Invoke("R4", 71.8f);
		Invoke("R1", 72.2f);
		Invoke("R3", 72.2f);
		Invoke("M", 72.6f);
		Invoke("R2", 72.6f);
		Invoke("R1", 72.8f);
		Invoke("R4", 72.8f);
		Invoke("R1", 73.2f);
		Invoke("R4", 73.2f);
		Invoke("M", 73.4f);
		Invoke("R3", 73.4f);
		Invoke("L4", 73.6f);
		Invoke("R2", 73.6f);
		Invoke("L1", 73.8f);
		Invoke("R4", 74.0f); 
		Invoke("M", 74.2f);
		Invoke("L1", 74.6f);
		Invoke("R3", 75.0f);
		Invoke("R1", 75.3f);
		Invoke("R3", 75.4f);
		Invoke("L3", 75.8f);
		Invoke("L1", 76.1f);
		Invoke("L3", 76.2f);
		Invoke("R2", 76.6f);
		Invoke("R2", 77.0f);
		Invoke("R2", 77.4f);
		Invoke("R3", 78.2f);
		Invoke("R1", 78.5f);
		Invoke("R3", 78.6f);
		Invoke("R2", 78.8f);
		Invoke("M", 79.0f);
		Invoke("L3", 79.2f);
		Invoke("L2", 79.3f);
		Invoke("L1", 79.4f);
		Invoke("R1", 79.8f);
		Invoke("R1", 80.2f);
		Invoke("R2", 80.8f);
		Invoke("R4", 80.9f);
		Invoke("M", 81.6f);
		Invoke("M", 81.8f);
		Invoke("L3", 83.4f);
		Invoke("M", 83.6f); //red-yellow three-half set
		Invoke("R3", 83.6f);
		Invoke("M", 83.8f);
		Invoke("R3", 83.8f);
		Invoke("M", 84.0f);
		Invoke("L1", 84.2f);
		Invoke("M", 84.4f);
		Invoke("R4", 84.6f);
		Invoke("R1", 84.8f);
		Invoke("R3", 85.0f);
		Invoke("L1", 85.2f);
		Invoke("L2", 85.4f); //
		Invoke("R2", 85.4f); //
		Invoke("L3", 85.6f);
		Invoke("M", 85.8f); //
		Invoke("R4", 85.8f); //
		Invoke("R3", 86.1f);
		Invoke("R2", 86.4f);
		Invoke("L4", 86.6f);
		Invoke("R1", 86.6f);
		Invoke("M", 87.0f);
		Invoke("R2", 87.1f);
		Invoke("L2", 87.3f);
		Invoke("L1", 87.4f);
		Invoke("R4", 87.4f);
		Invoke("R3", 87.8f);
		Invoke("L1", 88.0f);
		Invoke("L3", 88.2f);
		Invoke("M", 88.4f);
		Invoke("R1", 88.6f);
		Invoke("R3", 88.8f);
		Invoke("L3", 89.2f);
		Invoke("L1", 89.3f);
		Invoke("R3", 89.4f);
		Invoke("L1", 89.6f);
		Invoke("L2", 89.8f);
		Invoke("L4", 90.0f);
		Invoke("M", 90.2f);
		Invoke("R2", 90.4f);
		Invoke("R4", 90.5f);
		Invoke("L1", 90.6f);
		Invoke("R3", 91.0f);
		Invoke("L1", 91.2f);
		Invoke("L3", 91.4f);
		Invoke("M", 91.6f);
		Invoke("R1", 91.8f);
		Invoke("R3", 92.0f);
		Invoke("L3", 92.4f);
		Invoke("L1", 92.5f);
		Invoke("R3", 92.6f);
		Invoke("L1", 92.8f);
		Invoke("L2", 93.0f);
		Invoke("L4", 93.2f);
		Invoke("M", 93.4f);
		Invoke("R2", 93.6f);
		Invoke("L1", 93.8f); //ending
		Invoke("R4", 93.8f);
		Invoke("R3", 94.2f);
		Invoke("L1", 94.4f);
		Invoke("L3", 94.6f);
		Invoke("M", 94.8f);
		Invoke("R1", 95.0f);
		Invoke("R3", 95.2f);		
    }
	
	
	void L1() {
		Instantiate(PrefabL1,new Vector3(-3f, 6, 0), Quaternion.identity);
	}
	void L2() {
		Instantiate(PrefabL2,new Vector3(-2.25f, 6, 0), Quaternion.identity);
	}
	void L3() {
		Instantiate(PrefabL3,new Vector3(-1.5f, 6, 0), Quaternion.identity);
	}
	void L4() {
		Instantiate(PrefabL4,new Vector3(-0.75f, 6, 0), Quaternion.identity);
	}
	void M() {
		Instantiate(PrefabM,new Vector3(0, 6, 0), Quaternion.identity);
	}
	void R1() {
		Instantiate(PrefabR1,new Vector3(0.75f, 6, 0), Quaternion.identity);
	}
	void R2() {
		Instantiate(PrefabR2,new Vector3(1.5f, 6, 0), Quaternion.identity);
	}
	void R3() {
		Instantiate(PrefabR3,new Vector3(2.25f, 6, 0), Quaternion.identity);
	}
	void R4() {
		Instantiate(PrefabR4,new Vector3(3f, 6, 0), Quaternion.identity);
	}
}
