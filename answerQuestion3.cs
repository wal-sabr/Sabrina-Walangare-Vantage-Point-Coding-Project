// Q3. Write an algorithm that develops insights based on interpersonal distance.
// You can develop whatever "insights" you want.
// -- The Script is going to check if the distance between the two objects is too far or too near
// -- 3 Checking condition :
// --	1. Distance is too near
// --	2. Distance is too far
// --	3. Distance is within the "right" range
// -- We need to determine the "right" range, we are going to pick arbitary point range = 5 to 7.

using UnityEngine;
using System.Collections;
 
public class  : MonoBehaviour {
	
	private Vector3 sourceObject;
	private Vector3 targetObject;
	
	// Coordinate initialization
	void Start(){
		sourceObject = new Vector3(0, 0, 0);
		targetObject = new Vector3(1, 1, 2);
	}
	
	void Test(){
		Vector3[] positionArray = new [] { new Vector3(0f,0f,0f), new Vector3(1f,1f,1f) };
		float distance;
		Vector3 personalSpace;
		
		// If the target in range, if there is no one, we don't care
		if(targetsRange.Count >0){
		// Any target in range
			for (int i = 0; i < targetsRange.Count; i++){
				// Get distance between the target and sourceObject
				distance = Vector3.Distance(targetsRange[i].transform.position, source.position);
				//Check if target is too close to the source
				if (distance <= personalSpace){
				// Print message "To close to <Source>"
				print("You are too close to the target");				
				}
				//Check if target is too far from source
				else if(distance >= personalSpace){
				// Print message "Too near to <Target>"
					print("You are too far to the target");
				}
				//If the target in the correct range
				else{
					print("You are on the right range with the target");
				} 
			}
		}
	}		
	
    void Update() {
		Test();
    }
 
}














