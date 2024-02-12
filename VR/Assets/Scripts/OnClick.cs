using UnityEngine;

public class OnClick : MonoBehaviour
{
    // Llamado cuando se hace clic en el botón o elemento UI
    public void AbrirPaginaWeb()
    {
        // Reemplaza la URL con la que deseas abrir
        string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        Application.OpenURL(url);
    }
}
