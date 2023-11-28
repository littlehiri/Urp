using UnityEngine;

public class AumentarVelocidad : MonoBehaviour
{
    public string sueloTag = "SueloAumentaVelocidad"; // Tag del suelo que aumentará la velocidad
    public float aumentoDeVelocidad = 5.0f; // Incremento de velocidad al tocar el suelo
    private CharacterController characterController; // Referencia al CharacterController del jugador

    void Start()
    {
        characterController = GetComponent<CharacterController>(); // Obtiene el CharacterController del objeto al que está adjunto este script
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que ha colisionado tiene el tag del suelo que aumenta la velocidad
        if (other.CompareTag(sueloTag))
        {
            // Aumenta la velocidad del jugador sumándole el aumentoDeVelocidad
            characterController.Move(Vector3.forward * aumentoDeVelocidad * Time.deltaTime);
        }
    }
}
