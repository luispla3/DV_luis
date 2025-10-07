using UnityEngine;
using System.Collections;

public class EstadoRojo : ISMSemaforo {

	public Semaforo semaforo;

	public EstadoRojo(Semaforo s)
	{
		semaforo = s;
	}
	public void Update () {
		semaforo.estado = Semaforo.Estado.rojo;
		semaforo.duracionEstado += Time.deltaTime;
		if (semaforo.duracionEstado > semaforo.duracionRojo)
			aEstadoPrevioVerde ();
	}

	public void aEstadoRojo (){

	}
	public void aEstadoPrevioVerde (){
		semaforo.duracionEstado = 0;
		semaforo.currentState = semaforo.estadoPrevioVerde;
	}
	public void aEstadoAmbar (){

	}

	public void aEstadoVerde (){
		
	}
}
