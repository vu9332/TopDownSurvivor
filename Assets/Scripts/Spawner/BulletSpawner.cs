using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    public static BulletSpawner Instance { get; private set; }
    public static string bulletOne = "Bullet_1";
    public static string bulletTwo = "Bullet_2";

    protected override void Awake()
    {

        base.Awake();
        if (Instance == null)
            Instance = this;
    }
}
