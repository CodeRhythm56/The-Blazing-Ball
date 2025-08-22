using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsRoll : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Menu");
    }
}