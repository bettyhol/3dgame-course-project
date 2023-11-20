using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMain : MonoBehaviour
{
    // Имя сцены, которую вы хотите загрузить
    public string sceneName = "Menu";

    // Этот метод будет назначен кнопке в редакторе Unity через интерфейс
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

