using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jumptutorial : MonoBehaviour
{
    private bool Entered = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = true;
            GameObject.Find("jump").GetComponent<Text>().text = "Press Space To Jump";
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = false;
            GameObject.Find("jump").GetComponent<Text>().text = "";
        }
    }

    private void Update(){}
}
