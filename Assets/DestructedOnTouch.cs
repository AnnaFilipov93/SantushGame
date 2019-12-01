using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestructedOnTouch : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        int score =++player.GetComponent<ScoreKeeper>().score;
        Debug.Log(score);
        Destroy(this.gameObject,0);
        if (score >= 3) {
            SceneManager.LoadScene("WinScreen");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
