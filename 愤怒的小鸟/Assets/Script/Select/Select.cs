using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour
{

		public string[] levels;

		// Use this for initialization
		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	
		void OnGUI ()
		{
				GUILayout.BeginArea (new Rect (100, 100, 400, 400));
				GUILayout.BeginHorizontal ();
				foreach (string levelName in levels) {
						if (GUILayout.Button (levelName, GUILayout.Height (40))) {
								Application.LoadLevel (levelName);
						}
						GUILayout.Space (50);
				}
				GUILayout.EndHorizontal ();
				GUILayout.EndArea ();
		}
}
