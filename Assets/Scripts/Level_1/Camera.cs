using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Vector3 playerPos;

    private void Update()
    {
        try { Move(); }
        catch { }
        if (Input.GetButton("Cancel")) Application.Quit();
    }
    void Move()
    {
        playerPos = Player.Instance.transform.position;
        playerPos.z = 0f;
        transform.position = Vector3.Lerp(transform.position, playerPos, 2.5f * Time.deltaTime);
    }
}
