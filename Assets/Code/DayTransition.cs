using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTransition : MonoBehaviour {

	public float AlphaDecrement = 0.001f;
	private SpriteRenderer _SpriteRenderer;
	private Color _OldColor;
	private float _Alpha = 0;


	// Use this for initialization
	void Start () {
		_SpriteRenderer = GetComponent<SpriteRenderer> ();
		_OldColor = _SpriteRenderer.color;
		_Alpha = _SpriteRenderer.color.a;
	}
	
	// Update is called once per frame
	void Update () {
		_Alpha = _Alpha - AlphaDecrement;
		if (_Alpha <= 0) {
			_Alpha = _OldColor.a;
		}
		_SpriteRenderer.color = new Color (_OldColor.r, _OldColor.g, _OldColor.b, _Alpha);
	}
}
