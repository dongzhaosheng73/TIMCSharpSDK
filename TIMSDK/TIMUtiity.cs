using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TIMUtity
{
    /// <summary>
    /// Marshal unicode string param to utf-8 string,usage:[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]
    /// </summary>
    public class Utf8StringMarshaler : ICustomMarshaler
    {
        private static Utf8StringMarshaler _instance = new Utf8StringMarshaler();

        public Utf8StringMarshaler()
        {

        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj == null)
                return IntPtr.Zero;
            if (!(ManagedObj is string))
                throw new InvalidOperationException("Utf8StringMarshaler:ManagedObj must be string");

            byte[] utf8bytes = Encoding.UTF8.GetBytes(ManagedObj as string);
            IntPtr ptr = Marshal.AllocCoTaskMem(utf8bytes.Length + 1);
            Marshal.Copy(utf8bytes, 0, ptr, utf8bytes.Length);
            Marshal.WriteByte(ptr, utf8bytes.Length, 0);
            return ptr;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return null;
            List<byte> bytes = new List<byte>();
            for (int offset = 0; ; offset++)
            {
                byte b = Marshal.ReadByte(pNativeData, offset);
                if (b == 0)
                    break;
                else bytes.Add(b);
            }

            var str = Encoding.UTF8.GetString(bytes.ToArray(), 0, bytes.Count);
            return str;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeCoTaskMem(pNativeData);
            pNativeData = IntPtr.Zero;
        }

        public int GetNativeDataSize()
        {
            return -1;
        }

        public static ICustomMarshaler GetInstance(string s)
        {
            return _instance;
        }
    }

    /// <summary>
    /// 转换 CLR Delegate 和 Native function pointer
    /// </summary>
    public static class DelegateConverter
    {
        private static readonly Dictionary<IntPtr, string> _allocedMemDic = new Dictionary<IntPtr, string>();

        public static IntPtr ConvertToIntPtr(Delegate d)
        {
            if (d != null)
            {
                GCHandle gch = GCHandle.Alloc(d);
                IntPtr ptr = GCHandle.ToIntPtr(gch);
                _allocedMemDic[ptr] = d.Method.Name;
                return ptr;
            }
            return IntPtr.Zero;
        }

        public static IntPtr ConvertToIntPtr(object obj)
        {
            if (obj != null)
            {
                GCHandle gch = GCHandle.Alloc(obj);
                IntPtr ptr = GCHandle.ToIntPtr(gch);
                _allocedMemDic[ptr] = obj.ToString();
                return ptr;
            }
            return IntPtr.Zero;
        }

        public static T ConvertFromIntPtr<T>(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return default(T);
            GCHandle handle = GCHandle.FromIntPtr(ptr);
            var x = (T)handle.Target;
            return x;
        }

        public static object ConvertFromIntPtr(IntPtr ptr)
        {
            return ConvertFromIntPtr<object>(ptr);
        }

        public static void Invoke<TDelegate>(this IntPtr ptr, params object[] args)
        {
            var d = ConvertFromIntPtr<TDelegate>(ptr);
            var delegateObj = d as Delegate;
            if (delegateObj != null)
            {
                System.Diagnostics.Debug.Assert(CheckDelegateParams(delegateObj, args));
                delegateObj.Method.Invoke(delegateObj.Target, args);
            }
        }

        public static void InvokeOnce<TDelegate>(this IntPtr ptr, params object[] args)
        {
            var d = ConvertFromIntPtr<TDelegate>(ptr);
            var delegateObj = d as Delegate;
            if (delegateObj != null)
            {
                System.Diagnostics.Debug.Assert(CheckDelegateParams(delegateObj, args));
                delegateObj.Method.Invoke(delegateObj.Target, args);
                FreeMem(ptr);
            }
        }

        static bool CheckDelegateParams(Delegate d, params object[] args)
        {
            var ps = d.Method.GetParameters();
            if (args == null)
                return true;
            if (args.Count() != ps.Count())
                return false;
            for (int i = 0; i < args.Count(); i++)
            {
                if (args[i] == null || ps[i].ParameterType.IsValueType)
                    continue;
                if (!ps[i].ParameterType.IsInstanceOfType(args[i]))
                    return false;
            }
            return true;
        }

        public static void FreeMem(this IntPtr ptr)
        {
            _allocedMemDic.Remove(ptr);
            GCHandle handle = GCHandle.FromIntPtr(ptr);
            handle.Free();
        }

        public static void ClearHandles()
        {
            foreach (var item in _allocedMemDic)
            {
                GCHandle handle = GCHandle.FromIntPtr(item.Key);
                handle.Free();
            }
            _allocedMemDic.Clear();
        }
    }

    /// <summary>
    /// IntPtr 的一些辅助操作,解决.NET framework 4.0以下不支持IntPtr add等操作 
    /// </summary>
    public static class IntPtrExtensions
    {
        #region Methods: Arithmetics
        public static IntPtr Decrement(this IntPtr pointer, Int32 value)
        {
            return Increment(pointer, -value);
        }

        public static IntPtr Decrement(this IntPtr pointer, Int64 value)
        {
            return Increment(pointer, -value);
        }

        public static IntPtr Decrement(this IntPtr pointer, IntPtr value)
        {
            switch (IntPtr.Size)
            {
                case sizeof(Int32):
                    return (new IntPtr(pointer.ToInt32() - value.ToInt32()));

                default:
                    return (new IntPtr(pointer.ToInt64() - value.ToInt64()));
            }
        }

        public static IntPtr Increment(this IntPtr pointer, Int32 value)
        {
            unchecked
            {
                switch (IntPtr.Size)
                {
                    case sizeof(Int32):
                        return (new IntPtr(pointer.ToInt32() + value));

                    default:
                        return (new IntPtr(pointer.ToInt64() + value));
                }
            }
        }

        public static IntPtr Increment(this IntPtr pointer, Int64 value)
        {
            unchecked
            {
                switch (IntPtr.Size)
                {
                    case sizeof(Int32):
                        return (new IntPtr((Int32)(pointer.ToInt32() + value)));

                    default:
                        return (new IntPtr(pointer.ToInt64() + value));
                }
            }
        }

        public static IntPtr Increment(this IntPtr pointer, IntPtr value)
        {
            unchecked
            {
                switch (IntPtr.Size)
                {
                    case sizeof(int):
                        return new IntPtr(pointer.ToInt32() + value.ToInt32());
                    default:
                        return new IntPtr(pointer.ToInt64() + value.ToInt64());
                }
            }
        }

        public static IntPtr CreateFromeIntPtr(this IntPtr pointer)
        {
            unchecked
            {
                switch (IntPtr.Size)
                {
                    case sizeof(int):
                        return new IntPtr(Marshal.ReadInt32(pointer));
                    default:
                        return new IntPtr(Marshal.ReadInt64(pointer));
                }
            }
        }

        #endregion
    }
}
