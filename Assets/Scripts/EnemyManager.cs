using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour {

    public int enemiesLeft;
    public bool isLevelComplete;

    public GameObject levelCompleteText;
    // Use this for initialization
    void Awake () {
        enemiesLeft = SceneManager.GetActiveScene().buildIndex;
        isLevelComplete = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (enemiesLeft < 1)
        {
            isLevelComplete = true;
        }
        if (isLevelComplete)
        {
            Instantiate(levelCompleteText, Vector2.zero, Quaternion.identity);
            enemiesLeft = 1;
            isLevelComplete = false;
        }
    }
}
