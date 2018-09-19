using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endAchieved : MonoBehaviour
{

	public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
