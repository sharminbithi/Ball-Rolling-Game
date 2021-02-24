using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour
{
	public Transform coinTransform;
	public Vector3 direction;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		coinTransform.Rotate(direction);
	}
}
