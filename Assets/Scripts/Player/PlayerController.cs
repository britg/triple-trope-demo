using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    
    public enum CharacterType {
        Warrior,
        Thief,
        Mage
    }
    
    public CharacterType currentCharacterType = CharacterType.Warrior;
    public BaseCharacterController currentCharacterController;
    public BaseCharacterController warriorController;
    public BaseCharacterController thiefController;
    public BaseCharacterController mageController;

	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void OnRotate (int dir) {
        if (currentCharacterType == CharacterType.Warrior) {
            if (dir == 1) {
                ActivateThief();    
            } else {
                ActivateMage();
            }
        } else if (currentCharacterType == CharacterType.Thief) {
            if (dir == 1) {
                ActivateMage();    
            } else {
                ActivateWarrior();
            }
        } else {
            if (dir == 1) {
                ActivateWarrior();    
            } else {
                ActivateThief();   
            }
        }
    }
    
    void ActivateWarrior () {
        currentCharacterType = CharacterType.Warrior;
        currentCharacterController = warriorController;
    }
    
    void ActivateThief () {
        currentCharacterType = CharacterType.Thief;
        currentCharacterController = thiefController;
    }
    
    void ActivateMage () {
        currentCharacterType = CharacterType.Mage;
        currentCharacterController = mageController;
    }
}
