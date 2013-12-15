using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour
{
	
		public Texture normal ;
		public Texture clicked;
		public Texture picking;
		public Texture picked;
		private State state ;
		
		private enum State
		{
				Normal,
				Clicked,
				Picking,
				Picked
		}
		
		// Use this for initialization
		void Start ()
		{
				Screen.showCursor = false;
				state = State.Normal;
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	
		void OnGUI ()
		{
				Rect rect = new Rect (Input.mousePosition.x, Screen.height - Input.mousePosition.y, 32, 64);
				
				if (Input.GetMouseButton (0)) {
						state = State.Clicked;
				} else {
						state = State.Normal;
				}
				
				switch (state) {
				case State.Normal:
						GUI.DrawTexture (rect, normal);
						break;
				case State.Clicked:
						GUI.DrawTexture (rect, clicked);
						break;
				}
				
				GUI.depth = 1;
				GUILayout.Label (rect.ToString ());
		}
}
