using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : MonoBehaviour
{
	public GameObject target01;// Declaration vertex
	private float n = 20;

	// Update is called once per frame
	void Update()
	{

		this.transform.RotateAround(target01.transform.position, -Vector3.down, 100f * n * Time.deltaTime);// This function is placed in a vertex, and the X-axis to rotate around this vertex is given
																										  // vector3 vector, data with direction and size in the three-dimensional coordinate system, Vector3.up = (0, 1, 0), Vector3.Down = (0, -1, 0), Vector3.Left = (- 1 , 0, 0), Vector3.right = (1, 0, 0)

	}
}