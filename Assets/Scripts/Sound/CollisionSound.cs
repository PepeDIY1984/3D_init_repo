using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource sound;
    private void OnCollisionEnter(Collision collision)
    {
        sound.Play();
    }

}
