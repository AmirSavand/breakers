﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
	public float shakeDuration = 0;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1;

	private Vector3 originalPos;

	void OnEnable ()
	{
		originalPos = transform.localPosition;
	}

	void Update ()
	{
		if (shakeDuration > 0) {
			transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			shakeDuration -= Time.deltaTime * decreaseFactor;
		} else {
			shakeDuration = 0f;
			transform.localPosition = originalPos;
		}
	}

	public void shake (float duration = 0.1f)
	{
		// Set shake duration
		shakeDuration = duration;
	}
}