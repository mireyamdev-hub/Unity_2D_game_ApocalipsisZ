using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonIzq : MonoBehaviour
{
    public int speed = 20;
    public GameObject SpawnDisparoJug;
    public GameObject bullet;
    private void Update()
    {
        if (Input.touchCount>0)
        {
            checkTouchInput();
        }
    }
    void checkTouchInput()
    {
        RaycastHit h;
        Vector3 vektor = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0f);
        Ray ray = Camera.main.ScreenPointToRay(vektor);
        if (Physics.Raycast(ray, out h, Mathf.Infinity))
        {
            if (h.rigidbody == null) return;
            if (h.rigidbody.gameObject.name == "CubeIzq")
            {
                GetComponent<Rigidbody2D>().velocity = Vector3.left * speed * Time.timeScale;
            }
            else if (h.rigidbody.gameObject.name == "CubeDerecha")
            {
                GetComponent<Rigidbody2D>().velocity = Vector3.right * speed * Time.timeScale;
            }
            else if (h.rigidbody.gameObject.name == "CubeMedioDis")
            {
                Instantiate(bullet, SpawnDisparoJug.transform.position, Quaternion.identity);
            }
        }
    }
}
