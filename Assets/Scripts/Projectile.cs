using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public bool isLevelComplete = false;
    public float projectileSpeed;
    public float lifeTime;

    Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Invoke("DestroyProjectile", lifeTime);
    }
    void Update () {
        rb.velocity = transform.up * projectileSpeed * Time.deltaTime;
	}

    void DestroyProjectile(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enviroment")){
            Destroy(gameObject);
        }
    }

}
