using UnityEngine;
using System.Collections;

public class ShowLogo : MonoBehaviour
{

		public float sceneDelay = 10.00f;
		public float ShowDelay = 2;
		public string nextSceneName;
		
		private float timeCount ;//second
		private float maxAlpha = 1;
		private float alphaSpeed;
		private float alpha = 0;
		
		
		// Use this for initialization
		void Start ()
		{
				SetAlpha (0);
				alphaSpeed = maxAlpha / sceneDelay / (ShowDelay * 10);
		}
	
		// Update is called once per frame
		void Update ()
		{
				timeCount += Time.deltaTime;

				if (timeCount <= sceneDelay / 2) {
						alpha += alphaSpeed;
						SetAlpha (alpha);
				} else if (sceneDelay / 2 < timeCount && timeCount <= sceneDelay) {
						alpha -= alphaSpeed;
						SetAlpha (alpha);
				}

				if (timeCount >= sceneDelay) {
						if (string.IsNullOrEmpty (nextSceneName) == false) {
								Application.LoadLevel (nextSceneName);
						}
				}
		}

		void SetAlpha (float a)
		{
				if (alpha < 0) {
						alpha = 0;
				}
				if (alpha > 1) {
						alpha = 1;
				}

				Color c = guiTexture.color;
				guiTexture.color = new Color (c.r, c.g, c.b, a);
		}

}
