using UnityEngine;

namespace ScriptableValues
{
    [CreateAssetMenu(fileName = "CoordinatesForSpawn", menuName = "CoordinatesForSpawn")]
    public class CoordinatesForSpawn : ScriptableObject
    {
        public Vector3 destroyCubeSpawnCoordinates;
        public Vector3 expSphereSpawnCoordinates;
        public Vector3 damageCapsuleSpawnCoordinates;
        public Vector3 playerSpawnCoordinates;
        public Vector3 textSphereSpawnCoordinates;
        public Vector3 teleportSpawnCoordinates;
        public Vector3 spawnToAnotherSceneCubeCoordinates;
        public Vector3 capsuleForUseWithExperienceCoordinates;
    }
}