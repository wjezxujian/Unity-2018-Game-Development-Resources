﻿using UnityEngine;

public class InputScript : MonoBehaviour
{
	void Update ()
	{
		foreach (Touch touch in Input.touches)
		{
			float xMove = touch.deltaPosition.x * 0.05f;
			float yMove = touch.deltaPosition.y * 0.05f;

			if (touch.fingerId == 0 && gameObject.name == "Cube1")
				transform.Translate(xMove, yMove, 0F);
			
			if (touch.fingerId == 1 && gameObject.name == "Cube2") 
				transform.Translate(xMove, yMove, 0F);
			
			if (touch.fingerId == 2 && gameObject.name == "Cube3") 
				transform.Translate(xMove, yMove, 0F);
		}
	}
}
