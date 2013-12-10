using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

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
		
				if (GUILayout.Button ("Level1", GUILayout.Height (30))) {
						SceneLoader.SetLoadSceneName ("Level1");
				}
		}
}
