// Q1. Write a script that determines the distance between two players in an immersive environment.
// - Find a way to determine the distance between two objects
// - For easier code, we are going to use Unity Game Engine and their library
// - We are going to use C#
// - The Script is going to check if the distance between the two objects is too far or too near
// - 3 Checking condition :
// 	1. Distance is too near
// 	2. Distance is too far
// 	3. Distance is within the "right" range
// - We need to determine the "right" range, we are going to pick arbitary point range = 5 to 7.

// - based on the Unity documentation, we can use Vector3.Distance;
// 	- Advantage:
// 		- Easy to use
// 		- From the official documentation itself
// 	- Disadvantage:
// 		- Slow, not efficient
// - Another way is by do substraction between Object1 and Object2 in 3 axis: X axis, Y axis and Z axis.


using UnityEngine;
using System.Collections;
// we set the public class Test

public class Test: MonoBehaviour {
	private Vector3 firstObject;
	private Vector3 secondObject;
	
	// This is the initialization part, where we set the initial coordinates // for both objects
	void Start()
	{
		firstObject = new Vector3(1, 1, 1);
		secondObject = new Vector3(2, 2, 2);
	}
	
	//This is the checking the position of the objects
	void Test()
	{
		Vector3 heading;
		float distance;
		Vector3 direction;
		float distanceSquared;
		
		// For loop for checking the heading and the direction of the objects
		for(int i = 0; i < 10000; i++)
		{
			heading.x = firstObject.x - secondObject.x;
			heading.y = firstObject.y - secondObject.y;
			heading.z = firstObject.z - secondObject.z;
			
			distanceSquared = (heading.x * heading.x) + (heading.y * heading.y) + (heading.z * heading.z);
			// distance is the magnitude of the vector
			distance = Mathf.Sqrt(distanceSquared);
			
			direction.x = heading.x / distance;
			direction.y = heading.y / distance;
			direction.z = heading.z / distance;			
		}
		
	}
	
	// for the update
	void Update()
	{
		Test();
	}
}
