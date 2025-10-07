using UnityEngine;
using System.Collections;

public class Semaforo : MonoBehaviour {

	public enum Estado{rojo,ambar, verde,previo_verde};
	public Material rojo;
	public Material ambar;
	public Material verde;
	public Material rojoPeaton;
	public Material verdePeaton;
	[HideInInspector] public float duracionEstado = 0;
	public float duracionVerde = 6;
	public float duracionRojo = 6;
	public float duracionAmbar = 1;
	public float duracionPrevioVerde = 3;
	public float freqParpadeoVerde = 2;
	[HideInInspector] public float tiempoParpadeoVerde = 0;
	[HideInInspector] bool parpadeoEncendido=false;
	public Estado estado;

	[HideInInspector] public ISMSemaforo currentState;
	[HideInInspector] public EstadoVerde estadoVerde;
	[HideInInspector] public EstadoAmbar estadoAmbar;
	[HideInInspector] public EstadoPrevioVerde estadoPrevioVerde;
	[HideInInspector] public EstadoRojo estadoRojo;

	private void Awake()
	{
		estadoVerde = new EstadoVerde (this);
		estadoAmbar = new EstadoAmbar (this);
		estadoPrevioVerde = new EstadoPrevioVerde (this);
		estadoRojo = new EstadoRojo (this);


	}

	// Use this for initialization
	void Start () {
		currentState = estadoRojo;
		BuscaMateriales ();
	}

	void BuscaMateriales()
	{
		foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
			foreach (Material m in mr.materials) {
				if (m.name.StartsWith (rojo.name))
					rojo = m;
				else if (m.name.StartsWith (ambar.name))
					ambar = m;
				else if (m.name.StartsWith (verde.name))
					verde = m;
				else if (m.name.StartsWith (rojoPeaton.name))
					rojoPeaton = m;
				else if (m.name.StartsWith (verdePeaton.name))
					verdePeaton = m;
			}
	}

	void EntradaManual()
	{
		if (Input.GetKeyUp (KeyCode.Alpha1))
			estado = Estado.rojo;
		else if (Input.GetKeyUp (KeyCode.Alpha2))
			estado = Estado.ambar;
		else if (Input.GetKeyUp (KeyCode.Alpha3))
			estado = Estado.verde;
		else if (Input.GetKeyUp (KeyCode.Alpha4))
			estado = Estado.previo_verde;
	}

	// Update is called once per frame
	void Update () {
	

		currentState.Update();
		EntradaManual ();
		
		rojo.SetColor ("_EmissionColor", Color.black);
		ambar.SetColor ("_EmissionColor", Color.black);
		verde.SetColor ("_EmissionColor", Color.black);
		rojoPeaton.SetColor ("_EmissionColor", Color.black);
		verdePeaton.SetColor ("_EmissionColor", Color.black);

		switch (estado) {

		case Estado.rojo:
			rojo.SetColor ("_EmissionColor", Color.red);
			verdePeaton.SetColor ("_EmissionColor", Color.green);
			break;
		case Estado.previo_verde:
			tiempoParpadeoVerde += Time.deltaTime;
			if (tiempoParpadeoVerde>(1.0f/freqParpadeoVerde))
			{
				tiempoParpadeoVerde=0;
				parpadeoEncendido=!parpadeoEncendido;
			}
			rojo.SetColor ("_EmissionColor", Color.red);
			if (parpadeoEncendido)
				verdePeaton.SetColor ("_EmissionColor", Color.green);
			else
				verdePeaton.SetColor ("_EmissionColor", Color.black);
			break;
		case Estado.ambar:
			ambar.SetColor ("_EmissionColor", Color.yellow);
			rojoPeaton.SetColor ("_EmissionColor", Color.red);
			break;
		case Estado.verde:
			verde.SetColor ("_EmissionColor", Color.green);
			rojoPeaton.SetColor ("_EmissionColor", Color.red);
			break;
			}
	}
}
