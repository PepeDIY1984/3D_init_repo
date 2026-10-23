using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    public Transform Player;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.position);
        //transform.LookAt(new Vector3(Player.position.x,0,Player.position.z));
        transform.Translate(0, 0, speed*Time.deltaTime);
      
    }
}
