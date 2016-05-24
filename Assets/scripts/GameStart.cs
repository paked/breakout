using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameStart : MonoBehaviour {
    public void OnStartGame() {
        SceneManager.LoadScene("game");
    }
}