using UnityEngine;
using System.Collections;

public class EstadoPrevioVerde : ISMSemaforo {

	public Semaforo semaforo;

	public EstadoPrevioVerde(Semaforo s)
	{
		semaforo = s;
	}
	public void Update () {
		semaforo.estado = Semaforo.Estado.previo_verde;
		semaforo.duracionEstado += Time.deltaTime;
		if (semaforo.duracionEstado > semaforo.duracionPrevioVerde)
			aEstadoVerde ();
	}

	public void aEstadoRojo (){
		
	}
	public void aEstadoPrevioVerde (){

	}
	public void aEstadoAmbar (){

	}

	public void aEstadoVerde (){
		semaforo.duracionEstado = 0;
		semaforo.currentState = semaforo.estadoVerde;
	}
}
