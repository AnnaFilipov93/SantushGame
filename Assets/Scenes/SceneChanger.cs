using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GotoMainScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
