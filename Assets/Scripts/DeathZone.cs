using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    public GameObject levelFailed;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            Destroy(collision.gameObject);
            Instantiate(levelFailed, Vector2.zero, Quaternion.identity);
        } else{
            Destroy(collision.gameObject);
        }
        
    }
}
