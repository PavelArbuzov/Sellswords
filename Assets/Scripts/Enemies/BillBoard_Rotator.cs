﻿using UnityEngine;
using System.Collections;

public class BillBoard_Rotator : MonoBehaviour 
{
    Camera m_Camera;
   
	// Use this for initialization
	void Start () 
    {
        m_Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);
	}
}