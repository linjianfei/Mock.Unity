//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class TerrainData : Object
//    {
//        public TerrainData()
//        {
//            this.Internal_Create(this);
//        }
//
//        
//        internal extern void AddTree(out TreeInstance tree);
//        
//        internal extern void AddUser(GameObject user);
//        
//        internal extern int GetAdjustedSize(int size);
//        
//        public extern float[,,] GetAlphamaps(int x, int y, int width, int height);
//        
//        private extern Texture2D GetAlphamapTexture(int index);
//        
//        public extern int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer);
//        
//        public extern float GetHeight(int x, int y);
//        
//        public extern float[,] GetHeights(int xBase, int yBase, int width, int height);
//        
//        public extern float GetInterpolatedHeight(float x, float y);
//        
//        public extern Vector3 GetInterpolatedNormal(float x, float y);
//        
//        public extern float GetSteepness(float x, float y);
//        
//        public extern int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight);
//        
//        public extern TreeInstance GetTreeInstance(int index);
//        
//        internal extern bool HasUser(GameObject user);
//        
//        private static extern int INTERNAL_CALL_RemoveTrees(TerrainData self, ref Vector2 position, float radius, int prototypeIndex);
//        
//        private static extern void INTERNAL_CALL_SetTreeInstance(TerrainData self, int index, ref TreeInstance instance);
//        
//        internal extern void Internal_Create([Writable] TerrainData terrainData);
//        
//        private extern void INTERNAL_get_heightmapScale(out Vector3 value);
//        
//        private extern void INTERNAL_get_size(out Vector3 value);
//        
//        private extern void INTERNAL_get_wavingGrassTint(out Color value);
//        
//        private extern void INTERNAL_set_size(ref Vector3 value);
//        
//        private extern void INTERNAL_set_wavingGrassTint(ref Color value);
//        
//        private extern void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map);
//        
//        private extern void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data);
//        
//        private extern void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights);
//        
//        private extern void Internal_SetHeightsDelayLOD(int xBase, int yBase, int width, int height, float[,] heights);
//        
//        internal extern bool NeedUpgradeScaledTreePrototypes();
//        
//        internal extern void RecalculateBasemapIfDirty();
//        
//        internal extern void RecalculateTreePositions();
//        
//        public extern void RefreshPrototypes();
//        
//        internal extern void RemoveDetailPrototype(int index);
//        
//        internal extern void RemoveTreePrototype(int index);
//        internal int RemoveTrees(Vector2 position, float radius, int prototypeIndex)
//        {
//            return INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
//        }
//
//        
//        internal extern void RemoveUser(GameObject user);
//        
//        internal extern void ResetDirtyDetails();
//        public void SetAlphamaps(int x, int y, float[,,] map)
//        {
//            if (map.GetLength(2) != this.alphamapLayers)
//            {
//                object[] args = new object[] { this.alphamapLayers };
//                throw new Exception(UnityString.Format("Float array size wrong (layers should be {0})", args));
//            }
//            this.Internal_SetAlphamaps(x, y, map.GetLength(1), map.GetLength(0), map);
//        }
//
//        
//        internal extern void SetBasemapDirty(bool dirty);
//        public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details)
//        {
//            this.Internal_SetDetailLayer(xBase, yBase, details.GetLength(1), details.GetLength(0), layer, details);
//        }
//
//        
//        public extern void SetDetailResolution(int detailResolution, int resolutionPerPatch);
//        public void SetHeights(int xBase, int yBase, float[,] heights)
//        {
//            if (heights == null)
//            {
//                throw new NullReferenceException();
//            }
//            if (((((xBase + heights.GetLength(1)) > this.heightmapWidth) || ((xBase + heights.GetLength(1)) < 0)) || (((yBase + heights.GetLength(0)) < 0) || (xBase < 0))) || ((yBase < 0) || ((yBase + heights.GetLength(0)) > this.heightmapHeight)))
//            {
//                object[] args = new object[] { xBase + heights.GetLength(1), yBase + heights.GetLength(0), this.heightmapWidth, this.heightmapHeight };
//                throw new ArgumentException(UnityString.Format("X or Y base out of bounds. Setting up to {0}x{1} while map size is {2}x{3}", args));
//            }
//            this.Internal_SetHeights(xBase, yBase, heights.GetLength(1), heights.GetLength(0), heights);
//        }
//
//        public void SetHeightsDelayLOD(int xBase, int yBase, float[,] heights)
//        {
//            if (heights == null)
//            {
//                throw new ArgumentNullException("heights");
//            }
//            int length = heights.GetLength(0);
//            int width = heights.GetLength(1);
//            if (((xBase < 0) || ((xBase + width) < 0)) || ((xBase + width) > this.heightmapWidth))
//            {
//                object[] args = new object[] { xBase, xBase + width, this.heightmapWidth };
//                throw new ArgumentException(UnityString.Format("X out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", args));
//            }
//            if (((yBase < 0) || ((yBase + length) < 0)) || ((yBase + length) > this.heightmapHeight))
//            {
//                object[] objArray2 = new object[] { yBase, yBase + length, this.heightmapHeight };
//                throw new ArgumentException(UnityString.Format("Y out of bounds - trying to set {0}-{1} but the terrain ranges from 0-{2}", objArray2));
//            }
//            this.Internal_SetHeightsDelayLOD(xBase, yBase, width, length, heights);
//        }
//
//        public void SetTreeInstance(int index, TreeInstance instance)
//        {
//            INTERNAL_CALL_SetTreeInstance(this, index, ref instance);
//        }
//
//        
//        internal extern void UpgradeScaledTreePrototype();
//
//        public int alphamapHeight {  get; }
//
//        public int alphamapLayers {  get; }
//
//        public int alphamapResolution {  get;  set; }
//
//        private int alphamapTextureCount {  get; }
//
//        public Texture2D[] alphamapTextures
//        {
//            get
//            {
//                Texture2D[] texturedArray = new Texture2D[this.alphamapTextureCount];
//                for (int i = 0; i < texturedArray.Length; i++)
//                {
//                    texturedArray[i] = this.GetAlphamapTexture(i);
//                }
//                return texturedArray;
//            }
//        }
//
//        public int alphamapWidth {  get; }
//
//        public int baseMapResolution {  get;  set; }
//
//        public int detailHeight {  get; }
//
//        public DetailPrototype[] detailPrototypes {  get;  set; }
//
//        public int detailResolution {  get; }
//
//        internal int detailResolutionPerPatch {  get; }
//
//        public int detailWidth {  get; }
//
//        public int heightmapHeight {  get; }
//
//        public int heightmapResolution {  get;  set; }
//
//        public Vector3 heightmapScale
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_heightmapScale(out vector);
//                return vector;
//            }
//        }
//
//        public int heightmapWidth {  get; }
//
//        public Vector3 size
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_size(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_size(ref value);
//            }
//        }
//
//        public SplatPrototype[] splatPrototypes {  get;  set; }
//
//        public float thickness {  get;  set; }
//
//        public int treeInstanceCount {  get; }
//
//        public TreeInstance[] treeInstances {  get;  set; }
//
//        public TreePrototype[] treePrototypes {  get;  set; }
//
//        public float wavingGrassAmount {  get;  set; }
//
//        public float wavingGrassSpeed {  get;  set; }
//
//        public float wavingGrassStrength {  get;  set; }
//
//        public Color wavingGrassTint
//        {
//            get
//            {
//                Color color;
//                this.INTERNAL_get_wavingGrassTint(out color);
//                return color;
//            }
//            set
//            {
//                this.INTERNAL_set_wavingGrassTint(ref value);
//            }
//        }
//    }
//}
//
