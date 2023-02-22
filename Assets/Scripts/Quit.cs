using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string quit;

   public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(quit);
    }

}
