using UnityEngine;
using System.Collections;

public class EstadoVerde : ISMSemaforo {

	public Semaforo semaforo;

	public EstadoVerde(Semaforo s)
	{
		semaforo = s;
	}
	public void Update () {
		semaforo.estado = Semaforo.Estado.verde;
		semaforo.duracionEstado += Time.deltaTime;
		if (semaforo.duracionEstado > semaforo.duracionVerde)
			aEstadoAmbar ();
	}

	public void aEstadoRojo (){
	
	}
	public void aEstadoPrevioVerde (){
	
	}
	public void aEstadoAmbar (){
		semaforo.duracionEstado = 0;
		semaforo.currentState = semaforo.estadoAmbar;
	}

	public void aEstadoVerde (){
		
	}
}
