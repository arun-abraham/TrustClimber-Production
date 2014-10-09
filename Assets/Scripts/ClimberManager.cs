﻿using UnityEngine;
using System.Collections;

public class ClimberManager : MonoBehaviour {
	private static ClimberManager instance = null;
	public static ClimberManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = GameObject.FindGameObjectWithTag("Globals").GetComponent<ClimberManager>();
			}
			return instance;
		}
	}
	public ClimbInput climber1;
	public ClimbInput climber2;

	void Update()
	{

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.black;
		Gizmos.DrawLine(climber1.transform.position, climber2.transform.position);
	}

	public void ShowNearestHandholds(ClimbInput climber)
	{
		//Handhold top = HandholdManager.Instance.NearestHandhold(Handhold.ButtonType.Top,;
	}
}
