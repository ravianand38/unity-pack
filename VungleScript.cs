using System;

using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.UI;
public class VungleScript : MonoBehaviour
{
	static string windowsAppID = "5fa496c512dfda320e83aa7e";
	static string windowsINterstitialID = "INTER-8645005";

	void Update()
	{
		
			
			Init();
		

		
		
			LoadInterstitial();
	
	}


	public  void showadd()
	{
		Vungle.playAd(windowsINterstitialID);


	}




	public static void Init()
	{
		Vungle.init(windowsAppID);
	}

	public static void LoadInterstitial()
	{
		Vungle.loadAd(windowsINterstitialID);
	}

	
}

