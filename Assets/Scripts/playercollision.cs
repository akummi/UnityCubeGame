using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement pm;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("you hit an obstacle");
            pm.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
