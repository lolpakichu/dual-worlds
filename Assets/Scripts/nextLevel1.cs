﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel1 : MonoBehaviour {
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(nextSceneIndex);
        }
	}
}
