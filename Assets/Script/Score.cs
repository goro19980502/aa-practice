﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int Pincount;

    public Text text;

	// Use this for initialization
	void Start () {
        Pincount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Pincount.ToString();
	}
}
