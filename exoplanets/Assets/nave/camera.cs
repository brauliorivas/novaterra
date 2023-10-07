using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del mouse

    private float rotationX = 0.0f;

    void Update()
    {
        // Obtener la entrada del mouse para la rotación de la cámara
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Aplicar rotación en el eje horizontal (y)
        rotationX -= mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Limitar el ángulo de inclinación

        // Rotar la cámara y el jugador
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.parent.Rotate(Vector3.up * mouseX * sensitivity);
    }
}