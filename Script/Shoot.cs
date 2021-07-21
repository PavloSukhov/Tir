using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Weapons weapons;
    [SerializeField] private Camera cam;
    [SerializeField] private LayerMask mask;
    public Transform Bullet;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //стрельба на ЛКМ
        if (Input.GetButtonDown("Fire1"))
        {
            Transform BullerInstance = (Transform)Instantiate(Bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            BullerInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);

        }
    }
    public void Shooting()//стельба на кнопку
    {
        Transform BullerInstance = (Transform)Instantiate(Bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
            BullerInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
    }
}
