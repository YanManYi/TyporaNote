using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    public float speed = 20f;
	Vector3 angle ;
	// Use this for initialization
	void Start () {
		angle = transform.eulerAngles ;
	}
	
	// Update is called once per frame
	void Update () {
		angle.y += Time.deltaTime * speed;
		transform.eulerAngles = angle ;
	}
}
