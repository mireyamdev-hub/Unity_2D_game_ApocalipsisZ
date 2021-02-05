using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int speed = 30;
    ScriptGameManager scriptGameManager;
    GameObject gameManager;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed*Time.timeScale;
        gameManager = GameObject.Find("GameManager");
        scriptGameManager = gameManager.GetComponent<ScriptGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        string n = col.gameObject.name.Substring(0, 6); 
        if (n == "zombie")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            scriptGameManager.contarZombies();
            return;

        }
    }
}
