using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarGravedad : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 nuevaGravedad = new Vector3(0, -10, 0); // Modifica esto según la gravedad deseada

    void Start()
    {
        // Obtén el componente Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
        
        // Aplica la nueva gravedad
        rb.useGravity = true; // Asegúrate de que la gravedad esté habilitada
        rb.velocity = Vector3.zero; // Establece la velocidad inicial en cero para evitar comportamientos inesperados
        Physics.gravity = nuevaGravedad; // Establece la nueva gravedad
    }
}