using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeFollowing : MonoBehaviour
{
    public GameObject player;
    public int face;

    // Update is called once per frame
    void Update()
    {
        if (face == 0) {
            transform.position = new Vector3(player.transform.position.x + 0.13f, player.transform.position.y + 0.15f, 3);
        }
        if (face == 1)
        {
            transform.position = new Vector3(player.transform.position.x - 0.13f, player.transform.position.y + 0.15f, 3);
        }
    }
}
