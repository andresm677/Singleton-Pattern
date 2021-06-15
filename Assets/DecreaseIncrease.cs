using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseIncrease : MonoBehaviour
{
    public void Increase(){
        manager.instance.score += 1;
    }
    public void Decrease(){
        manager.instance.score -= 1;
    }
}
