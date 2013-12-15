using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour
{
	
		public GUISkin skin;
		public int guiDepth = -5;
		public Rect rect;
		public string playScene;
		
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
				GUI.skin = skin;
				if (GUI.Button (rect, "PLAY", "PlayButton")) {
						Application.LoadLevel (playScene);
				}
				
				GUI.depth = guiDepth;
		}
}
