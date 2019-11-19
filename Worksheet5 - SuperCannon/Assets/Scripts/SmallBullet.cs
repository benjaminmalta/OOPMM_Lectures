using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullet //inheritance with Bullet (parent)
{
    // Start is called before the first frame update
    protected override void Start()
    {
        speed = 30;
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
