using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlArea : MonoBehaviour
{
    private bool Entered = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = true;
            GameObject.Find("Text").GetComponent<Text>().text = "Press LeftShift To Run";
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = false;
            GameObject.Find("Text").GetComponent<Text>().text = "";
        }
    }

    private void Update(){}
}
