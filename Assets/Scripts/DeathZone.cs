using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    public GameObject levelFailed;
    public bool isLevelFailed = false;

    private void Update()
    {
        if(isLevelFailed){
            Instantiate(levelFailed, Vector2.zero, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            isLevelFailed = true;
            Destroy(collision.gameObject);
        } else{
            Destroy(collision.gameObject);
        }
        
    }
}
