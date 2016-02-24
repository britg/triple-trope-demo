using UnityEngine;
using System.Collections;

public abstract class BaseCharacterController : MonoBehaviour {

	public abstract void OnAttack ();
    public abstract void OnStopAttack ();
}
