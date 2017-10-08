namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Caching
    {
        [Obsolete("Size is now specified as a long")]
        public static bool Authorize(string name, string domain, int size, string signature)
        {
            return Authorize(name, domain, (long) size, signature);
        }

        public static bool Authorize(string name, string domain, long size, string signature)
        {
            return Authorize(name, domain, size, -1, signature);
        }

        [Obsolete("Size is now specified as a long")]
        public static bool Authorize(string name, string domain, int size, int expiration, string signature)
        {
            return Authorize(name, domain, (long) size, expiration, signature);
        }

        
        public static extern bool Authorize(string name, string domain, long size, int expiration, string signature);
        
        public static extern bool CleanCache();
        
        public static extern bool CleanNamedCache(string name);
        
        public static extern bool DeleteFromCache(string url);
        
        public static extern int GetVersionFromCache(string url);
        
        private static extern bool INTERNAL_CALL_IsVersionCached(string url, ref Hash128 hash);
        
        private static extern bool INTERNAL_CALL_MarkAsUsed(string url, ref Hash128 hash);
        
        private static extern void INTERNAL_CALL_ResetNoBackupFlag(string url, ref Hash128 hash);
        
        private static extern void INTERNAL_CALL_SetNoBackupFlag(string url, ref Hash128 hash);
        public static bool IsVersionCached(string url, int version)
        {
            Hash128 hash = new Hash128(0, 0, 0, (uint) version);
            return IsVersionCached(url, hash);
        }

        public static bool IsVersionCached(string url, Hash128 hash)
        {
            return INTERNAL_CALL_IsVersionCached(url, ref hash);
        }

        public static bool MarkAsUsed(string url, int version)
        {
            Hash128 hash = new Hash128(0, 0, 0, (uint) version);
            return MarkAsUsed(url, hash);
        }

        public static bool MarkAsUsed(string url, Hash128 hash)
        {
            return INTERNAL_CALL_MarkAsUsed(url, ref hash);
        }

        public static void ResetNoBackupFlag(string url, int version)
        {
        }

        public static void ResetNoBackupFlag(string url, Hash128 hash)
        {
            INTERNAL_CALL_ResetNoBackupFlag(url, ref hash);
        }

        public static void SetNoBackupFlag(string url, int version)
        {
        }

        public static void SetNoBackupFlag(string url, Hash128 hash)
        {
            INTERNAL_CALL_SetNoBackupFlag(url, ref hash);
        }

        public static bool enabled {  get;  set; }

        public static int expirationDelay {  get;  set; }

        [Obsolete("this API is not for public use.")]
        public static CacheIndex[] index {  get; }

        public static long maximumAvailableDiskSpace {  get;  set; }

        public static bool ready {  get; }

        [Obsolete("Please use Caching.spaceFree instead")]
        public static int spaceAvailable {  get; }

        public static long spaceFree {  get; }

        public static long spaceOccupied {  get; }

        [Obsolete("Please use Caching.spaceOccupied instead")]
        public static int spaceUsed {  get; }
    }
}

