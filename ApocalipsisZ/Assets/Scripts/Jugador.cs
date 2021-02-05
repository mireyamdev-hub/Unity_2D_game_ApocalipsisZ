using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int speed = 30;
    public string axis = "Horizontal";
    public GameObject SpawnDisparoJug;
    public GameObject bullet;

    void Start()
    {

    }

    void Update()
    {
        float moverLateral = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(moverLateral, 0) * speed * Time.timeScale;
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bullet, SpawnDisparoJug.transform.position, Quaternion.identity);
        }
    }
}
