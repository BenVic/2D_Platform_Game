using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour 
{

public Sprite[] spriteDigits;
public int value = 0;
public float spacing = 0.4f;
private int displayValue = -1;


	void Update()
		{
		if (displayValue != value)
		{
		string digits = value.ToString();

		SpriteRenderer[] renderers = GetComponentsInChildren<SpriteRenderer>();

		int numRenderers = renderers.Length;

		if(numRenderers < digits.Length)
		{
			while(numRenderers < digits.Length)
			{
				GameObject spr = new GameObject();

				spr.AddComponent<SpriteRenderer>();

				spr.transform.parent = transform;

				spr.transform.localPosition = new Vector3(numRenderers * spacing, 0.0f, 0.0f);
				                                        
				spr.layer = 5;
				       
				numRenderers = numRenderers + 1;
			
				}
		

				renderers = GetComponentsInChildren<SpriteRenderer>();
			
				
			}
				

			else if(numRenderers > digits.Length)


			{
						
				while(numRenderers > digits.Length)
				{
					renderers[numRenderers-1].sprite = null;

					numRenderers = numRenderers -1;

				}
			}

				int rendererIndex = 0;
				foreach(char digit in digits)
				{
					int spriteIndex = int.Parse(digit.ToString());
					renderers[rendererIndex].sprite = spriteDigits[spriteIndex];

					rendererIndex = rendererIndex +1;
				}
				displayValue = value;

				}
			} //you ready for destruction?
}



	