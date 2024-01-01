using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZidererA.CommonFuncCSharp.Models
{
    //https://stackoverflow.com/questions/4537803/overloading-assignment-operator-in-c-sharp
    //Need to float, short, ushort, BitArray, bool[]
    public readonly struct UniNum
    {
        private byte[] Value { get; }

        private UniNum(byte[] value)
        {
            Value = value;
        }
        public UniNum()
        {
            Value = new byte[]{};
        }

        public static implicit operator UniNum(float[] value)
        {
            List<byte> retArr = new List<byte>();
            foreach (var val in value)
                retArr.AddRange(BitConverter.GetBytes(val));
            return new UniNum(retArr.ToArray());
        }
     
        public static implicit operator UniNum(short[] value)
        {
            List<byte> retArr = new List<byte>();
            foreach (var val in value)
                retArr.AddRange(BitConverter.GetBytes(val));
            return new UniNum(retArr.ToArray());
        }
        
        public static implicit operator UniNum(ushort[] value)
        {
            List<byte> retArr = new List<byte>();
            foreach (var val in value)
                retArr.AddRange(BitConverter.GetBytes(val));
            return new UniNum(retArr.ToArray());
        }
        

        public static implicit operator UniNum(float value) => new(BitConverter.GetBytes(value));

        public static implicit operator UniNum(short value) => new(BitConverter.GetBytes(value));

        public static implicit operator UniNum(ushort value) => new(BitConverter.GetBytes(value));


        public float[] GetFloats()
        {
            List<float> retArr = new List<float>();
            for (int i = 0; i < Value.Length; i += 4)
                retArr.Add(BitConverter.ToSingle(Value, i));
            return retArr.ToArray();
        }
        
        public short[] GetShorts()
        {
            List<short> retArr = new List<short>();
            for (int i = 0; i < Value.Length; i += 2)
                retArr.Add(BitConverter.ToInt16(Value, i));
            return retArr.ToArray();
        }
        
        public ushort[] GetUShorts()
        {
            List<ushort> retArr = new List<ushort>();
            for (int i = 0; i < Value.Length; i += 2)
                retArr.Add(BitConverter.ToUInt16(Value, i));
            return retArr.ToArray();
        }
    }
}
