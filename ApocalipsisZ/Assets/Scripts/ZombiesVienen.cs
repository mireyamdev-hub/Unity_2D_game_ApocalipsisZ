using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesVienen : MonoBehaviour
{
    public int speed = 2;
    public GameObject SpawnZombie;
    public GameObject SpawnZombie1;
    public GameObject SpawnZombie2;
    public GameObject SpawnZombie3;

    public GameObject zombiespritesheetci3_12; 
    public GameObject zombiespritesheetci3_12_1;
    public GameObject zombiespritesheetci3_12_2;
    public GameObject zombiespritesheetci3_12_3;
    
    public float tiempoEntreZombies = 2;
    public float tiempo;
    public bool enter = true;
    

    // Start is called before the first frame update
    void Start()
    {
        tiempo = Time.time;
        zombiespritesheetci3_12.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed * Time.time;
        zombiespritesheetci3_12_1.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed * Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ( (Time.time-tiempo) > tiempoEntreZombies)
        {
            //Instantiate zombi
            int i = (int)Random.Range(1f, 4f);
            switch (i)
            {
                case 1:
                    Instantiate(zombiespritesheetci3_12, SpawnZombie.transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(zombiespritesheetci3_12_1, SpawnZombie1.transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(zombiespritesheetci3_12_2, SpawnZombie2.transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(zombiespritesheetci3_12_3, SpawnZombie3.transform.position, Quaternion.identity);
                    break;   
            }

            tiempo = Time.time;
        }

    }

}
