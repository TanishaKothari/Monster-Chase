using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [HideInInspector]
    public Transform Player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;

    [HideInInspector]
    public static CameraFollow Instance;

    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!Player)
            return;

        tempPos = transform.position;
        tempPos.x = Player.position.x;

        if (tempPos.x < minX)
            tempPos.x = minX;

        if (tempPos.x > maxX)
            tempPos.x = maxX;

        transform.position = tempPos;
    }
}
