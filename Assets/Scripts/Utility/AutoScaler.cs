﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aUTOsCALER : MonoBehaviour {

    public float scaleSpeed;
	
	// Update is called once per frame
	void Update () {
		transform.localScale += (new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime);
    }
}
