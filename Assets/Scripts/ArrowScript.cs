/*using UnityEngine;
using System.Collections;

public class ArrowScript :MonoBehaviour
{

	public GameObject player;
	GameObject destination;
	GameObject Target;

	float height = 5.0f;
	Color farColor = new Color(128.0f/255.0f, 0, 0, 1); // maroon
	Color nearColor = new Color(255.0f/255.0f, 215.0f/255.0f, 0, 1); // gold

	float distance;
	void Start()
	{
		PlayerPrefs.SetString("EndLoc", "Nipple");
		if(destination == null)
		{
			destination = GameObject.Find(PlayerPrefs.GetString("EndLoc"));
			Instantiate (Target, destination.transform.position, Quaternion.identity);
		}
		distance = (player.transform.position - destination.transform.position).magnitude;
	}

	void Update()
	{
		float percentage = (player.transform.position - destination.transform.position).magnitude / distance;
		transform.Find("Default/Object_1").GetComponent(MeshRenderer).renderer.material.color = Color.Lerp(nearColor,farColor,percentage);
		
		transform.position = player.transform.position;
		//transform.position.y = GameObject.Find("Main Camera").transform.position.y;
		transform.position.y = Camera.main.ScreenToWorldPoint(new Vector3(0,0,0)).y;
		transform.position.y += height;
		Vector3 lookTarget = new Vector3(destination.transform.position.x, destination.transform.position.y, destination.transform.position.z);
		lookTarget.y -= 180;
		transform.LookAt(lookTarget);
	}
}*/