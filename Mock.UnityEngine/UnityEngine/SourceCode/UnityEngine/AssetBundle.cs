//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using UnityEngineInternal;
//
//    public sealed class AssetBundle : Object
//    {
//        [Obsolete("This method is deprecated. Use GetAllAssetNames() instead.")]
//        public string[] AllAssetNames()
//        {
//            return this.GetAllAssetNames();
//        }
//
//        
//        public extern bool Contains(string name);
//        
//        public static extern AssetBundle CreateFromFile(string path);
//        
//        public static extern AssetBundleCreateRequest CreateFromMemory(byte[] binary);
//        
//        public static extern AssetBundle CreateFromMemoryImmediate(byte[] binary);
//        
//        public extern string[] GetAllAssetNames();
//        
//        public extern string[] GetAllScenePaths();
//        [Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
//        public Object Load(string name)
//        {
//            return null;
//        }
//
//        [Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", true)]
//        public T Load<T>(string name) where T: Object
//        {
//            return null;
//        }
//
//        
//        public extern Object Load(string name, Type type);
//        [Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
//        public Object[] LoadAll()
//        {
//            return null;
//        }
//
//        [Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", true)]
//        public T[] LoadAll<T>() where T: Object
//        {
//            return null;
//        }
//
//        
//        public extern Object[] LoadAll(Type type);
//        public Object[] LoadAllAssets()
//        {
//            return this.LoadAllAssets(typeof(Object));
//        }
//
//        public T[] LoadAllAssets<T>() where T: Object
//        {
//            return Resources.ConvertObjects<T>(this.LoadAllAssets(typeof(T)));
//        }
//
//        public Object[] LoadAllAssets(Type type)
//        {
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAssetWithSubAssets_Internal(string.Empty, type);
//        }
//
//        public AssetBundleRequest LoadAllAssetsAsync()
//        {
//            return this.LoadAllAssetsAsync(typeof(Object));
//        }
//
//        public AssetBundleRequest LoadAllAssetsAsync<T>()
//        {
//            return this.LoadAllAssetsAsync(typeof(T));
//        }
//
//        public AssetBundleRequest LoadAllAssetsAsync(Type type)
//        {
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAssetWithSubAssetsAsync_Internal(string.Empty, type);
//        }
//
//        public Object LoadAsset(string name)
//        {
//            return this.LoadAsset(name, typeof(Object));
//        }
//
//        public T LoadAsset<T>(string name) where T: Object
//        {
//            return (T) this.LoadAsset(name, typeof(T));
//        }
//
//        [TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
//        public Object LoadAsset(string name, Type type)
//        {
//            if (name == null)
//            {
//                throw new NullReferenceException("The input asset name cannot be null.");
//            }
//            if (name.Length == 0)
//            {
//                throw new ArgumentException("The input asset name cannot be empty.");
//            }
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAsset_Internal(name, type);
//        }
//
//        
//        private extern Object LoadAsset_Internal(string name, Type type);
//        public AssetBundleRequest LoadAssetAsync(string name)
//        {
//            return this.LoadAssetAsync(name, typeof(Object));
//        }
//
//        public AssetBundleRequest LoadAssetAsync<T>(string name)
//        {
//            return this.LoadAssetAsync(name, typeof(T));
//        }
//
//        public AssetBundleRequest LoadAssetAsync(string name, Type type)
//        {
//            if (name == null)
//            {
//                throw new NullReferenceException("The input asset name cannot be null.");
//            }
//            if (name.Length == 0)
//            {
//                throw new ArgumentException("The input asset name cannot be empty.");
//            }
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAssetAsync_Internal(name, type);
//        }
//
//        
//        private extern AssetBundleRequest LoadAssetAsync_Internal(string name, Type type);
//        public Object[] LoadAssetWithSubAssets(string name)
//        {
//            return this.LoadAssetWithSubAssets(name, typeof(Object));
//        }
//
//        public T[] LoadAssetWithSubAssets<T>(string name) where T: Object
//        {
//            return Resources.ConvertObjects<T>(this.LoadAssetWithSubAssets(name, typeof(T)));
//        }
//
//        public Object[] LoadAssetWithSubAssets(string name, Type type)
//        {
//            if (name == null)
//            {
//                throw new NullReferenceException("The input asset name cannot be null.");
//            }
//            if (name.Length == 0)
//            {
//                throw new ArgumentException("The input asset name cannot be empty.");
//            }
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAssetWithSubAssets_Internal(name, type);
//        }
//
//        
//        internal extern Object[] LoadAssetWithSubAssets_Internal(string name, Type type);
//        public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
//        {
//            return this.LoadAssetWithSubAssetsAsync(name, typeof(Object));
//        }
//
//        public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
//        {
//            return this.LoadAssetWithSubAssetsAsync(name, typeof(T));
//        }
//
//        public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type)
//        {
//            if (name == null)
//            {
//                throw new NullReferenceException("The input asset name cannot be null.");
//            }
//            if (name.Length == 0)
//            {
//                throw new ArgumentException("The input asset name cannot be empty.");
//            }
//            if (type == null)
//            {
//                throw new NullReferenceException("The input type cannot be null.");
//            }
//            return this.LoadAssetWithSubAssetsAsync_Internal(name, type);
//        }
//
//        
//        private extern AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type);
//        
//        public extern AssetBundleRequest LoadAsync(string name, Type type);
//        
//        public extern void Unload(bool unloadAllLoadedObjects);
//
//        public Object mainAsset {  get; }
//    }
//}
//
