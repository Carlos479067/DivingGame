using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerController playerController;
    public int damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EnemyDamage script is running.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Enemy hit the player!");
            playerController.TakeDamage(damage);
        }
    }
}
