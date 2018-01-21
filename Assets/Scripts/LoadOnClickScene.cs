using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClickScene : MonoBehaviour {

	public void LoadScene(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
    }
}
