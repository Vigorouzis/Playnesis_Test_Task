using UnityEngine;

namespace ScriptableValues
{
    [CreateAssetMenu(fileName = "ScriptableInt", menuName = "ScriptableInt")]
    public class PlayerIndicators : ScriptableObject
    {
        public double health;
        public double experience;
   

    }
}