using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
	public GameManager GM;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("kibble"))
		{
			GM.ScoreCount();
			Destroy(collision.gameObject);
			



        }



    }
}
