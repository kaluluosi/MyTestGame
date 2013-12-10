using UnityEngine;
using System.Collections;



public class FullScreen : MonoBehaviour
{
		public enum Style
		{
				FullScreen,
				Center,
				Zoomer
		}
		
		public bool fullScreen = false;
		// Use this for initialization
		void Start ()
		{
				Rect inset = new Rect ();
				if (fullScreen) {
						inset.height = Screen.height;
						inset.width = Screen.width;
				} else {
						inset.height = guiTexture.pixelInset.height;
						inset.width = guiTexture.pixelInset.width;
				}
		
				inset.x = -inset.width / 2;
				inset.y = -inset.height / 2;
		
		
				guiTexture.pixelInset = inset;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		
}


