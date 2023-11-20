using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMenu : MonoBehaviour
{
    // Имя сцены, которую вы хотите загрузить
    public string sceneName = "LevelMenu";

    // Этот метод будет назначен кнопке в редакторе Unity через интерфейс
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
