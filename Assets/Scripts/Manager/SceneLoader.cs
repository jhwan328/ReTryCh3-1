using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static public SceneLoader instance = null;

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Button_MoveToClassScene()
    {
        SceneManager.LoadScene("ClassScene");
    }
    public void Button_MoveToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
