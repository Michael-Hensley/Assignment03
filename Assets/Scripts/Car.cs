using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	float speed = SliderCarSpeed.carSpeed;

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Boundary")
		{
			Destroy(gameObject);
			Debug.Log("Car Destroyed");
		}
	}

}
