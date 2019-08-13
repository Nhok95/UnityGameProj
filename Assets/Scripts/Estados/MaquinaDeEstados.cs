using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour {

	public MonoBehaviour EstadoPatrulla;
	public MonoBehaviour EstadoAlerta;
	public MonoBehaviour EstadoPersecusion;
	public MonoBehaviour EstadoInicial;

	private MonoBehaviour estadoActual;


	void Start () 
	{
		ActivarEstado (EstadoInicial);
	}

	public void ActivarEstado(MonoBehaviour nEstado) 
	{
		if (estadoActual!= null) estadoActual.enabled = false;
		estadoActual = nEstado;
		estadoActual.enabled = true;
	}

}
