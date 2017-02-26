using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public GameObject player;
  public float offsetValue;
  private Vector3 offset;
  private BoxCollider2D bc2d;

	void Start ()
  {
    bc2d = GetComponent<BoxCollider2D>();
    offset = this.transform.position - player.transform.position;
	}
	
	void LateUpdate ()
  {
    this.transform.position = player.transform.position + offset;
  }
}
