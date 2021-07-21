using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetGreen : MonoBehaviour
{
    private int r=7;
    Renderer render;
    private GameObject target;
    public bool shoot = false;
    private float timer=0;
    public int v;
    void Start()
    {
        v = 0;
    }

    void Update()
    {
        //таймер для появления целей
        timer += Time.deltaTime;
        target = GameObject.Find("GreenCube" + r);
        MeshRenderer mesh = target.GetComponent<MeshRenderer>();
        mesh.enabled = true;// появление цели
            if (shoot == true || timer >= 10) //действия при попадании в цель
            {
                timer = 0;
                mesh.enabled = false;
                shoot = false;
                r = Random.Range(0, 6);
                v++;
            }
            //действия в случаи с поражением 10 целей
            if (v == 10)
            {
                SceneManager.LoadScene(2);
            }
            
        }
        
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            shoot = true;
        }
    }

}