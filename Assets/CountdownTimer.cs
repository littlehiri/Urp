using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 60.0f; // Tiempo inicial en segundos
    public Text countdownText; // Referencia al objeto Text donde se mostrará el tiempo restante
    public string levelToLoad = "MainScene"; // Nombre del nivel a reiniciar

    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime; // Reduce el tiempo actual

        if (currentTime <= 0)
        {
            currentTime = 0; // Asegura que el tiempo no sea negativo
            RestartLevel(); // Llama a la función para reiniciar el nivel
        }

        DisplayTime();
    }

    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60); // Calcula los minutos
        int seconds = Mathf.FloorToInt(currentTime % 60); // Calcula los segundos

        // Formatea el tiempo restante en el formato MM:SS y lo muestra en el objeto Text
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene("Mapa"); // Carga el nivel especificado
    }
}