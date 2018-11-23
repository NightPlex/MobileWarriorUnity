using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class MossGiant : Enemy {

    public override void Update() {
        HandleMoveAi();
    }

    //User for initialization
    protected override void Init() {
        base.Init();
    }
   
}