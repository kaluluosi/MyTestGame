using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
		private static string sceneName;
		
		public static void SetLoadSceneName (string name)
		{
				sceneName = name;
				Application.LoadLevel ("Loading");
		}
		
		public static string SceneName {
				get { return sceneName;}
		}
		
		public static void LoadScene ()
		{
				try {
						Application.LoadLevel (sceneName);
				} catch (System.Exception ex) {
						Debug.LogError (ex);
				}
		}
			
		// Use this for initialization
		void Start ()
		{
				
		}
	
		// Update is called once per frame
		void Update ()
		{
				
		}
		
}
