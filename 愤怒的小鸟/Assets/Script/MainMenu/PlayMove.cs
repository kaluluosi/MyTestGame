using UnityEngine;
using System.Collections;

public class PlayMove : MonoBehaviour
{
		public float end = -20;
		public float start = -20;
		public bool decideByLayer = false;
		public float speed = 1;
		public float layerSpeed = 0;
		// Use this for initialization
		void Start ()
		{
				if (decideByLayer) {
						SpriteRenderer spRender = GetComponent<SpriteRenderer> ();
						layerSpeed += spRender.sortingLayerID;
						layerSpeed += layerSpeed * spRender.sortingOrder * 0.1f;
						speed = speed * layerSpeed;
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.Translate (Vector3.left * speed * Time.deltaTime);
				if (transform.position.x < end) {
						transform.position = new Vector3 (start, transform.position.y, 0f);
				}
		}
}
