using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
		//中文版
		
		public AudioClip brake;
		public float frequance;
		private Transform groundCheck;
		private bool grounded;
		
		// Use this for initialization
	
		private Animator anim;

		void Start ()
		{
				anim = GetComponentInChildren<Animator> ();
				groundCheck = transform.Find ("GroundCheck");
				InvokeRepeating ("Brake", 0, frequance);
		}
	
		// Update is called once per frame
		void Update ()
		{
				grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));
				anim.SetBool ("Grounded", grounded);
		}
		
		void FixedUpdate ()
		{
				
		}
		
		public void Brake ()
		{
				int i = Random.Range (0, 100);
				if (i > 50) {
						anim.SetTrigger ("Brake");
						audio.clip = brake;
						audio.Play ();
				}
		}
		
}
