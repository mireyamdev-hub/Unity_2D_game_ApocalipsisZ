using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGameManager : MonoBehaviour
{
    int numEnemigos = 0;
    public int speed = 2;
    public GameObject SpawnZombie;
    public GameObject SpawnZombie1;
    public GameObject SpawnZombie2;
    public GameObject SpawnZombie3;

    public GameObject zombiespritesheetci3_12;

    public GameObject CanvasFinPartida;

    public float tiempoEntreZombies = 2;
    public float tiempo;
    public bool enter = true;
    void Start()
    {
        Time.timeScale = 1;
        CanvasFinPartida.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - tiempo) > tiempoEntreZombies)
        {
            int i = (int)Random.Range(1f, 4f);
            switch (i)
            {
                case 1:
                    Instantiate(zombiespritesheetci3_12, SpawnZombie.transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(zombiespritesheetci3_12, SpawnZombie1.transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(zombiespritesheetci3_12, SpawnZombie2.transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(zombiespritesheetci3_12, SpawnZombie3.transform.position, Quaternion.identity);
                    break;
            }

            tiempo = Time.time;

        }
    }
    public void contarZombies()
    {
        numEnemigos++;
        if(numEnemigos == 10)
        {
            finPartida();
        }
    }
    public void finPartida()
    {
        Time.timeScale = 0;
        CanvasFinPartida.SetActive(true);
    }
    public void OnClickJugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
