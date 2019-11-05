using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBalloonController : MonoBehaviour
{
    public GameObject explodeCollider;

    private void OnDestroy()
    {
        Instantiate(explodeCollider, null);
    }
}
