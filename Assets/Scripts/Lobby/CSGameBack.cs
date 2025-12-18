using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSGameBack : MonoBehaviour {

	public CSGameBackData data;
	public Image image;
	public Button playButton;
	public float imageOffset;

	void Start ()
	{
		image.sprite = data.sprite;
		Vector2 size = new Vector2(285, 325);  //data.sprite.rect.size;
		image.rectTransform.sizeDelta = size;
		image.rectTransform.anchoredPosition = new Vector3 (0f, imageOffset);
	}
}
