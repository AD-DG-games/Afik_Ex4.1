using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] MyLife myLife;

    [SerializeField] string lose;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            myLife.incLife();
            if(myLife.getLife() == 0){
                Debug.Log("Game over!");
                SceneManager.LoadScene(lose);    // Input can either be a serial number or a name; here we use name
                // UnityEditor.EditorApplication.isPlaying = false;  # Error on editor 2021.3
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
