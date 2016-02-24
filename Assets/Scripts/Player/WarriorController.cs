using UnityEngine;
using System.Collections;

public class WarriorController : BaseCharacterController {
    
    public GameObject weaponTrigger;
    public WarriorWeapon weapon;
    
    bool attacking = false;
    

	// Use this for initialization
	void Start () {
	   weaponTrigger.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
    
    public override void OnAttack () {
        Debug.Log("#Warrior# attacking");
        if (!attacking) {
            StartAttack();    
        }
    }
    
    public override void OnStopAttack () {
        Debug.Log("#Warrior# stop attacking");
    }
    
    void StartAttack () {
        attacking = true;
        weaponTrigger.SetActive(true); 
        // TODO do some sort of animation
        new tpd.Wait(this, weapon.duration, () => {
            EndAttack();
        });
    }
    
    void EndAttack () {
        weaponTrigger.SetActive(false);
        new tpd.Wait(this, weapon.cooldown, () => {
           ReleaseAttackHold(); 
        });
    }
    
    void ReleaseAttackHold () {
        attacking = false;
    }
    
    public void OnHitMob (MobController mobController) {
        Debug.Log("#Warrior# hit mob " + mobController);
        mobController.TakeMeleeDamage(weapon.damage);
    }
}
