using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

    public string FirstLevel;

    public void Update(){

        if (!Input.GetMouseButtonDown(0))
            return;

        GameManager.Instance.Reset();
        SceneManager.LoadScene(FirstLevel);
    }
}
