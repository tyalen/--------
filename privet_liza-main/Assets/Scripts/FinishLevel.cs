using UnityEngine;
using UnityEngine.SceneManagement; // Подключение библиотеки для управления сценами

public class FinishLevel : MonoBehaviour
{

    // Метод, который вызывается при входе в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошел игрок (или другой нужный объект)
        if (other.CompareTag("Player"))
        {
            // Загружаем указанную сцену
            SceneManager.LoadScene("Main menu");
        }
    }
}
