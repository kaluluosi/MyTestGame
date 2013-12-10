using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour
{
		public enum DisplayMode
		{
				FullScreen,
				Center,
		}
	
		public DisplayMode mode = DisplayMode.FullScreen;
		public bool Zoomer = false;
		private Vector2 scale;
		
		
		// Use this for initialization
		void Start ()
		{
				scale = new Vector2 ();
				scale.x = Screen.height / guiTexture.pixelInset.height;
				scale.y = Screen.width / guiTexture.pixelInset.width;
		}
	
		// Update is called once per frame
		void Update ()
		{
				Rect inset = new Rect ();
				switch (mode) {
				case DisplayMode.FullScreen:
						inset.height = Screen.height;
						inset.width = Screen.width;

//						inset.height = guiTexture.pixelInset.height;
//						inset.width = guiTexture.pixelInset.width;
				
						inset.x = -inset.width / 2;
						inset.y = -inset.height / 2;
					
						guiTexture.pixelInset = inset;
						break;
				case DisplayMode.Center:
						float x = -guiTexture.pixelInset.width / 2;
						float y = -guiTexture.pixelInset.height / 2;
						
						if (Zoomer == false) {
								inset.width = guiTexture.pixelInset.width;
								inset.height = guiTexture.pixelInset.height;
						} else {
								inset.width = Screen.width / scale.x;
								inset.height = Screen.height / scale.y;
						}
						
						inset.x = x;
						inset.y = y;
						
						guiTexture.pixelInset = inset;
						break;

				default:
						break;
				}
			
		}

		
}


