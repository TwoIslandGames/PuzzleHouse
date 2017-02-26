using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadrantController : MonoBehaviour {
  private BoxCollider2D bc2d;
  private SpriteRenderer sr;


	// Use this for initialization
	void Start ()
  {
    bc2d = GetComponent<BoxCollider2D>();
    sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
  {
		
	}

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.name == "Vision")
    {
      //Debug.Log("enter");
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.name == "Vision")
    {
      Debug.Log("exit");
      sr.color = Color.blue;
      }
  }
}
