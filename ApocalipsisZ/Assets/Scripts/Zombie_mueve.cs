using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_mueve : MonoBehaviour
{
    public int speed = 15;
    ScriptGameManager scriptGameManager;
    GameObject gameManager;
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.down * speed * Time.timeScale;
    }

    void Update()
    {
        gameManager = GameObject.Find("GameManager");
        scriptGameManager = gameManager.GetComponent<ScriptGameManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "shooter" || col.gameObject.name == "bloqueInferior")
        {
            scriptGameManager.finPartida();
            return;
        }
    }

}
