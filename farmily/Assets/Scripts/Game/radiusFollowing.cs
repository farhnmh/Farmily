using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiusFollowing : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 0.4f, -10);
    }
}
