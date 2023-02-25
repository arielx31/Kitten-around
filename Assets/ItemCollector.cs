using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
	public int score;
	public TextMeshProUGUI scoreUI;

	void Update()
    {
		scoreUI.text = score.ToString();
    }


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("kibble"))
		{
			Destroy(collision.gameObject);
			score++;
			



        }



    }
}
