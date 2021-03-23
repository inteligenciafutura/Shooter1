using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsHUD : MonoBehaviour
{
    public GameObject PlayerNPC;

    public void Animation1()
    {
        PlayerNPC.GetComponent<Animator>().Play("House Dancing");
    }

    public void Animation2()
    {
        PlayerNPC.GetComponent<Animator>().Play("Macarena Dance");
    }

    public void Animation3()
    {
        PlayerNPC.GetComponent<Animator>().Play("Wave Hip Hop Dance");
    }
}
