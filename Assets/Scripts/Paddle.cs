using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float xMin = 1f;
    [SerializeField] float xMax = 15f;

	// Update is called once per frame
	void Update () {
        float mouseePosInUnits = (Input.mousePosition.x / Screen.width * screenWidthInUnits);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x =  Mathf.Clamp(mouseePosInUnits, xMin, xMax);
        transform.position = paddlePos;
	}
}
