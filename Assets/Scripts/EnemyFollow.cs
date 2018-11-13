using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    public float speed;

    public bool isLevelComplete;

    private bool movingRight = true;

    public Transform groundDetection;
    public GameObject levelCompleteText;
    public DeathZone deathZone;
	// Use this for initialization
	void Start () {
        isLevelComplete = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);

        if(groundInfo.collider == false){
            if(movingRight){
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

        }

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            deathZone.isLevelFailed = true;
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag("Bullet")){

            isLevelComplete = true;
            Instantiate(levelCompleteText, Vector2.zero, Quaternion.identity);
            Debug.Log("Level Complete");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
