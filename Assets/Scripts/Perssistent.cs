using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perssistent : MonoBehaviour
{
    public string PlayerName = "";
    public static Perssistent Instance;

	//Persistencia de datos
	private void Awake()
	{
		if (Instance)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}

}
