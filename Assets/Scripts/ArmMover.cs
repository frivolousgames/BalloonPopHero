using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMover : MonoBehaviour
{
    Quaternion startPos;

    private void Awake()
    {
        startPos = Quaternion.identity;
    }

    public void PointAtTouch()
    {
        Vector3 dir = Input.mousePosition - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -21.5f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void Drag()
    {
        Vector3 dir = Input.mousePosition - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 21.5f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void ReturnToStartAim()
    {

        transform.rotation = startPos;
    }
}
