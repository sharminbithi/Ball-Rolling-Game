using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
	private int Score;
	public Text scoreText;
	public Text Endtext;
	public int count;
	public AudioSource sound;
	public float speed;
	public Rigidbody rigid;
	public float hAxis;
	public float vAxis;

	// Use this for initialization
	void Start()
	{
		Score = 0;
		SetScoreText();
		Endtext.text = "";
	}

	// Update is called once per frame
	void Update()
	{
		hAxis = Input.GetAxis("Horizontal");
		vAxis = Input.GetAxis("Vertical");
		var force = new Vector3(hAxis, 0f, vAxis);
		rigid.AddForce(force * speed);


	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Coin")
		{
			sound.Play();
			Destroy(other.gameObject);
			Score++;
			SetScoreText();
		}
	}
	void SetScoreText() { 
			scoreText.text = "Score: " + Score.ToString();
			if(Score>=7)
            {
				Endtext.text = "GAME OVER!";

			}
		}

	}

