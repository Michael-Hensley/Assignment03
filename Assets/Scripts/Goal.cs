using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public Rigidbody2D rb;
	void OnTriggerEnter2D ()
	{
		Score.CurrentScore += (100 * SliderCarSpeed.carSpeed) - (DropdownLives.numLives * 100);
		rb.transform.position = new Vector3(0, -4, 0);
	}

}
