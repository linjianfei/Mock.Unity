namespace UnityEngine
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    internal class InternalStaticBatchingUtility
    {
 

        public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene)
        {
            GameObject[] objArray = (GameObject[]) Object.FindObjectsOfType(typeof(GameObject));
            List<GameObject> list = new List<GameObject>();
            foreach (GameObject obj2 in objArray)
            {
             
            }
            CombineGameObjects(list.ToArray(), staticBatchRoot, isEditorPostprocessScene);
        }

        public static void CombineGameObjects(GameObject[] gos, GameObject staticBatchRoot, bool isEditorPostprocessScene)
        {
        }

        public static void CombineRoot(GameObject staticBatchRoot)
        {
            Combine(staticBatchRoot, false, false);
        }

        private static void MakeBatch(List<MeshSubsetCombineUtility.MeshInstance> meshes, List<MeshSubsetCombineUtility.SubMeshInstance> subsets, List<GameObject> subsetGOs, Transform staticBatchRootTransform, int batchIndex)
        {
            if (meshes.Count >= 2)
            {
                MeshSubsetCombineUtility.MeshInstance[] instanceArray = meshes.ToArray();
                MeshSubsetCombineUtility.SubMeshInstance[] submeshes = subsets.ToArray();
                string meshName = "Combined Mesh";
                meshName = meshName + " (root: " + ((staticBatchRootTransform == null) ? "scene" : staticBatchRootTransform.name) + ")";
                if (batchIndex > 0)
                {
                    meshName = meshName + " " + (batchIndex + 1);
                }
                Mesh combinedMesh = StaticBatchingUtility.InternalCombineVertices(instanceArray, meshName);
                StaticBatchingUtility.InternalCombineIndices(submeshes, combinedMesh);
                int subSetIndexForMaterial = 0;
                for (int i = 0; i < submeshes.Length; i++)
                {
                  
                    subSetIndexForMaterial++;
                }
            }
        }

       
    }
}

