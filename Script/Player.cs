using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedTouchField touchField;
    public Joystick joystick;
    Rigidbody rb;
    float xMov;
    float zMov;
    float yRot;
    public int speed = 5;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //управление персонажем
        xMov = joystick.Horizontal();
        zMov = joystick.Vertical();
        //поворот персонажа
        yRot = touchField.TouchDist.x / 20;

        Vector3 MovHor = transform.right * xMov;
        Vector3 MovVer = transform.forward * zMov;

        Vector3 velocity = (MovHor + MovVer).normalized * speed;
        Vector3 rotation = new Vector3(0, yRot, 0) * speed;

        rb.MovePosition(rb.position + velocity * Time.deltaTime);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));


    }
}