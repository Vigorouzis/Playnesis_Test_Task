using UnityEngine;

namespace ScriptableValues
{
    [CreateAssetMenu(fileName = "QuantitiesForChanges", menuName = "QuantitiesForChanges")]
    public class QuantitiesForChanges : ScriptableObject
    {
        public int damage;
        public int addExp;
    }
}