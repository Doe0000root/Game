using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mission : MonoBehaviour
{
    private bool Entered = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = true;
			this.GetComponent<Animator>().SetTrigger("mis");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Entered = false;
			this.GetComponent<Animator>().SetTrigger("norm");
        }
    }

    private void Update(){}
}
