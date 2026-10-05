using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaRespawn : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("te estas quemando");

        SceneManager.LoadScene(1);
    }

}
