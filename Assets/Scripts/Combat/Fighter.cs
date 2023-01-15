using UnityEngine;

namespace ARPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        public void Attack(CombatTarget target) 
        {
            print($"Attack {target.name}");
        }   
    }
}