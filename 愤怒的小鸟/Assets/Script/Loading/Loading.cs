using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour
{


		private float processValue = 0;
		private float processMax = 100;
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				processValue += Time.deltaTime * 5;
		
				if (processValue > processMax) {
						SceneLoader.LoadScene ();
				}
		
		}
	
		void OnGUI ()
		{
//				GUILayout.Box (processValue + "/" + processMax, GUILayout.Height (50));
				GUI.Box (new Rect (30, 30, (int)processValue + 40, 30), (int)processValue + "/" + (int)processMax);
		}
}
