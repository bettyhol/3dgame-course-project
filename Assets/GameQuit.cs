using UnityEngine;

public class ButtonCloseGame : MonoBehaviour
{
    // Обработчик события On Click
    public void OnButtonClick()
    {
        // Закрываем игру
        Application.Quit();
    }
}
