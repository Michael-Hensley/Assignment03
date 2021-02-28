using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
	int frogLives;
	public Text frogLivesTXT;
	string frogName;
	public Text frogNameTXT;
	
	void Start()
	{
		frogLives = DropdownLives.numLives;
		frogLivesTXT.text = ("Lives: " + frogLives);
		frogName = InputName.frogName;
		frogNameTXT.text = ("Frog " + frogName);
		
	}
	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			frogLives -= 1;
		
			if(frogLives == 0)
			{
				SceneManager.LoadScene(2);
				Debug.Log("Exit to Credits");
			}
			else
			{
				rb.transform.position = new Vector3(0, -4, 0);
				frogLivesTXT.text = ("Lives: " + frogLives);
			}
			//Debug.Log("WE LOST!");
			//Score.CurrentScore = 0;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		if (col.tag == "Boundary")
		{
			rb.transform.position = new Vector3(0, -4, 0);
			Debug.Log("Out of Bounds");
		}
	}
}
