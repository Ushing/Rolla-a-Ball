using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Science_Manager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
