using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyCharacter : MonoBehaviour
{
 //a variable to hold the current destination of the character
 Vector3 _Destination;
 //a veriable to hold the path that unity calculates for us
 private UnityEngine.AI.NavMeshPath _path;
 //a “list” which contains the waypoints that we will navigate to
 List<Vector3> _simplePath = new List<Vector3>();
 // Start is called before the first frame update
 void Start()
 {
 //when we start, set the destination to whatever the current position is
 _Destination = transform.position;
 _path = new UnityEngine.AI.NavMeshPath();
 }
 //a function to set the target desitnation of the character
 public void SetTarget(Vector3 TargetPos)
 {
 _Destination = TargetPos;
 //find a path to the destination from our current position
 bool foundPath = UnityEngine.AI.NavMesh.CalculatePath(transform.position, TargetPos, UnityEngine.AI.NavMesh.AllAreas, _path);
 //copy the way points in this path out into our list
 _simplePath.Clear();
 for (int i = 0; i < _path.corners.Length; i++)
 {
 _simplePath.Add(_path.corners[i]);
 }
 }
 // Update is called once per frame
 void Update()
 {
 //when updating, work out the direction we need to move in
 
 Vector3 MoveDirection = Vector3.zero;
 //remove any parts of our path that we are really close to
 while (_simplePath.Count > 0 && (transform.position - _simplePath[0]).magnitude < 0.5f)
 {
 _simplePath.RemoveAt(0);
 }
 //if there is still path to travel, calculate the direction
 if (_simplePath.Count > 0)
 { 
 MoveDirection = _simplePath[0] - transform.position; 
 }
 
 //if the destination is a reasonable distance away, update the characters rotation to point in this direction
 if (MoveDirection.magnitude > 0.5f)
 {
 MoveDirection.Normalize();
 transform.rotation = Quaternion.LookRotation(MoveDirection);
 //set a variable in the animation controller 
 GetComponent<Animator>().SetFloat("WalkSpeed", 2.0f);
 }
 else
 { 
 
 //set a variable in the animation controller
 GetComponent<Animator>().SetFloat("WalkSpeed", 0.0f);
 
 }
 }
}
