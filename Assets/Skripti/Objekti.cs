using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabās visus velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject b2;
	public GameObject policija;
	public GameObject eskavators;
	public GameObject traktors1;
	public GameObject traktors5;
	public GameObject e61;
	public GameObject ugunsdzeseji;


	//Uzglabās katra transportlīdzekļa sākotnējo atrāšanās 
	// vietu
	[HideInInspector]
	public Vector2 atkrMKoord;
    [HideInInspector]
    public Vector2 atrPKoord;
    [HideInInspector]
    public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 policijaKoord;
	[HideInInspector]
	public Vector2 eskavatorsKoord;
	[HideInInspector]
	public Vector2 traktors1Koord;
	[HideInInspector]
	public Vector2 traktors5Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 ugunsdzesejiKoord;

	public Canvas kanva;

	//Uzglabās audio avotu, kurā atskaņot 
	// audio efektus
	public AudioSource skanasAvots;
	//Uzlgabās audio failus
	public AudioClip[] skanaKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

    void Start () {
		//Uzsākot spēli piefiksē
		// kur sākotnēji atrodas katra mašīna
		atkrMKoord =
		atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;
        
		bussKoord =
        autobuss.GetComponent<RectTransform>().localPosition;
		
		cementKoord =
			cementaMasina.GetComponent<RectTransform>().localPosition;
		
		e46Koord =
			e46.GetComponent<RectTransform>().localPosition;
		
		b2Koord =
			b2.GetComponent<RectTransform>().localPosition;
		
		policijaKoord =
			policija.GetComponent<RectTransform>().localPosition;
		
		eskavatorsKoord =
			eskavators.GetComponent<RectTransform>().localPosition;
		
		traktors1Koord =
			traktors1.GetComponent<RectTransform>().localPosition;
		
		traktors5Koord =
			traktors5.GetComponent<RectTransform>().localPosition;
		
		e61Koord =
			e61.GetComponent<RectTransform>().localPosition;
		
		ugunsdzesejiKoord =
			ugunsdzeseji.GetComponent<RectTransform>().localPosition;
		
    }
}
