using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

}
