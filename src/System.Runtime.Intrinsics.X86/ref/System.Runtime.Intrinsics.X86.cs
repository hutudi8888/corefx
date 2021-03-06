// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Vector128<T> where T : struct {}
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct Vector256<T> where T : struct {}
}

namespace System.Runtime.Intrinsics.X86
{
    public static class Aes 
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<sbyte> Decrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> DecryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> Encrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> EncryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> InvisibleMixColumn(Vector128<sbyte> value) { throw null; }
        public static Vector128<byte> InvisibleMixColumn(Vector128<byte> value) { throw null; }
        public static Vector128<sbyte> KeygenAssist(Vector128<sbyte> value, byte control) { throw null; }
        public static Vector128<byte> KeygenAssist(Vector128<byte> value, byte control) { throw null; }
    }
    public static class Avx
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> AddSubtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> AddSubtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> And(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> And(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> AndNot(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> AndNot(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Blend(Vector256<float> left, Vector256<float> right, byte control) { throw null; }
        public static Vector256<double> Blend(Vector256<double> left, Vector256<double> right, byte control) { throw null; }
        public static Vector256<float> BlendVariable(Vector256<float> left, Vector256<float> right, Vector256<float> mask) { throw null; }
        public static Vector256<double> BlendVariable(Vector256<double> left, Vector256<double> right, Vector256<double> mask) { throw null; }
        public static Vector128<float> BroadcastElementToVector128(ref float source) { throw null; }
        public static unsafe Vector256<float> BroadcastVector128ToVector256(float* address) { throw null; }
        public static Vector256<float> BroadcastElementToVector256(ref float source) { throw null; }
        public static unsafe Vector256<double> BroadcastVector128ToVector256(double* address) { throw null; }
        public static Vector256<double> BroadcastElementToVector256(ref double source) { throw null; }
        public static Vector256<float> Ceiling(Vector256<float> value) { throw null; }
        public static Vector256<double> Ceiling(Vector256<double> value) { throw null; }
        public static Vector128<float> Compare(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) { throw null; }
        public static Vector128<double> Compare(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) { throw null; }
        public static Vector256<float> Compare(Vector256<float> left, Vector256<float> right, FloatComparisonMode mode) { throw null; }
        public static Vector256<double> Compare(Vector256<double> left, Vector256<double> right, FloatComparisonMode mode) { throw null; }
        public static Vector128<int> ConvertToVector128Int(Vector256<double> value) { throw null; }
        public static Vector128<float> ConvertToVector128Float(Vector256<double> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int(Vector256<float> value) { throw null; }
        public static Vector256<float> ConvertToVector256Float(Vector256<int> value) { throw null; }
        public static Vector256<double> ConvertToVector256Double(Vector256<float> value) { throw null; }
        public static Vector256<double> ConvertToVector256Double(Vector256<int> value) { throw null; }
        public static Vector128<int> ConvertToVector128IntWithTruncation(Vector256<double> value) { throw null; }
        public static Vector256<int> ConvertToVector256IntWithTruncation(Vector256<float> value) { throw null; }
        public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> DotProduct(Vector256<float> left, Vector256<float> right, byte control) { throw null; }
        public static Vector256<float> DuplicateEvenIndexed(Vector256<float> value) { throw null; }
        public static Vector256<double> DuplicateEvenIndexed(Vector256<double> value) { throw null; }
        public static Vector256<float> DuplicateOddIndexed(Vector256<float> value) { throw null; }
        public static sbyte ExtractSbyte<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static byte ExtractByte<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static short ExtractShort<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static ushort ExtractUshort<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static int ExtractInt<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static uint ExtractUint<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static long ExtractLong<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static ulong ExtractUlong<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static Vector128<T> ExtractVector128<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static unsafe void ExtractVector128(byte* address, Vector256<byte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(sbyte* address, Vector256<sbyte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(short* address, Vector256<short> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ushort* address, Vector256<ushort> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(int* address, Vector256<int> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(uint* address, Vector256<uint> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(long* address, Vector256<long> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ulong* address, Vector256<ulong> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(float* address, Vector256<float> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(double* address, Vector256<double> value, byte index) { throw null; }
        public static Vector256<T> ExtendToVector256<T>(Vector128<T> value) where T : struct { throw null; }
        public static Vector256<float> Floor(Vector256<float> value) { throw null; }
        public static Vector256<double> Floor(Vector256<double> value) { throw null; }
        public static Vector128<T> GetLowerHalf<T>(Vector256<T> value) where T : struct { throw null; }
        public static Vector256<float> HorizontalAdd(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> HorizontalAdd(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> HorizontalSubtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> HorizontalSubtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<T> InsertSbyte<T>(Vector256<T> value, sbyte data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertByte<T>(Vector256<T> value, byte data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertShort<T>(Vector256<T> value, short data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertUshort<T>(Vector256<T> value, ushort data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertInt<T>(Vector256<T> value, int data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertUint<T>(Vector256<T> value, uint data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertLong<T>(Vector256<T> value, long data, byte index) where T : struct { throw null; }
        public static Vector256<T> InsertUlong<T>(Vector256<T> value, ulong data, byte index) where T : struct { throw null; }
        public static Vector256<T> Insert<T>(Vector256<T> value, Vector128<T> data, byte index) where T : struct { throw null; }
        public static unsafe Vector256<sbyte> Insert(Vector256<sbyte> value, sbyte* address, byte index) { throw null; }
        public static unsafe Vector256<byte> Insert(Vector256<byte> value, byte* address, byte index) { throw null; }
        public static unsafe Vector256<short> Insert(Vector256<short> value, short* address, byte index) { throw null; }
        public static unsafe Vector256<ushort> Insert(Vector256<ushort> value, ushort* address, byte index) { throw null; }
        public static unsafe Vector256<int> Insert(Vector256<int> value, int* address, byte index) { throw null; }
        public static unsafe Vector256<uint> Insert(Vector256<uint> value, uint* address, byte index) { throw null; }
        public static unsafe Vector256<long> Insert(Vector256<long> value, long* address, byte index) { throw null; }
        public static unsafe Vector256<ulong> Insert(Vector256<ulong> value, ulong* address, byte index) { throw null; }
        public static unsafe Vector256<float> Insert(Vector256<float> value, float* address, byte index) { throw null; }
        public static unsafe Vector256<double> Insert(Vector256<double> value, double* address, byte index) { throw null; }
        public static unsafe Vector256<sbyte> Load(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> Load(byte* address) { throw null; }
        public static unsafe Vector256<short> Load(short* address) { throw null; }
        public static unsafe Vector256<ushort> Load(ushort* address) { throw null; }
        public static unsafe Vector256<int> Load(int* address) { throw null; }
        public static unsafe Vector256<uint> Load(uint* address) { throw null; }
        public static unsafe Vector256<long> Load(long* address) { throw null; }
        public static unsafe Vector256<ulong> Load(ulong* address) { throw null; }
        public static unsafe Vector256<float> Load(float* address) { throw null; }
        public static unsafe Vector256<double> Load(double* address) { throw null; }
        public static unsafe Vector256<sbyte> LoadAligned(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadAligned(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadAligned(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadAligned(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadAligned(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadAligned(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadAligned(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadAligned(ulong* address) { throw null; }
        public static unsafe Vector256<float> LoadAligned(float* address) { throw null; }
        public static unsafe Vector256<double> LoadAligned(double* address) { throw null; }
        public static unsafe Vector256<sbyte> LoadDqu(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadDqu(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadDqu(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadDqu(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadDqu(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadDqu(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadDqu(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadDqu(ulong* address) { throw null; }
        public static unsafe Vector128<float> MaskLoad(float* address, Vector128<uint> mask) { throw null; }
        public static unsafe Vector128<double> MaskLoad(double* address, Vector128<ulong> mask) { throw null; }
        public static unsafe Vector256<float> MaskLoad(float* address, Vector256<uint> mask) { throw null; }
        public static unsafe Vector256<double> MaskLoad(double* address, Vector256<ulong> mask) { throw null; }
        public static unsafe void MaskStore(float* address, Vector128<float> mask, Vector128<uint> source) { throw null; }
        public static unsafe void MaskStore(double* address, Vector128<double> mask, Vector128<ulong> source) { throw null; }
        public static unsafe void MaskStore(float* address, Vector256<float> mask, Vector256<uint> source) { throw null; }
        public static unsafe void MaskStore(double* address, Vector256<double> mask, Vector256<ulong> source) { throw null; }
        public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) { throw null; }
        public static int MoveMask(Vector256<float> value) { throw null; }
        public static int MoveMask(Vector256<double> value) { throw null; }
        public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Or(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Or(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector128<float> Permute(Vector128<float> value, byte control) { throw null; }
        public static Vector128<double> Permute(Vector128<double> value, byte control) { throw null; }
        public static Vector256<float> Permute(Vector256<float> value, byte control) { throw null; }
        public static Vector256<double> Permute(Vector256<double> value, byte control) { throw null; }
        public static Vector256<float> Permute2x128(Vector256<float> left, Vector256<float> right, byte control) { throw null; }
        public static Vector256<double> Permute2x128(Vector256<double> left, Vector256<double> right, byte control) { throw null; }
        public static Vector128<float> PermuteVar(Vector128<float> left, Vector128<float> mask) { throw null; }
        public static Vector128<double> PermuteVar(Vector128<double> left, Vector128<double> mask) { throw null; }
        public static Vector256<float> PermuteVar(Vector256<float> left, Vector256<float> mask) { throw null; }
        public static Vector256<double> PermuteVar(Vector256<double> left, Vector256<double> mask) { throw null; }
        public static Vector256<float> Reciprocal(Vector256<float> value) { throw null; }
        public static Vector256<float> ReciprocalSqrt(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToNearestInteger(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToNegativeInfinity(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToPositiveInfinity(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToZero(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundCurrentDirection(Vector256<float> value) { throw null; }
        public static Vector256<double> RoundToNearestInteger(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToNegativeInfinity(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToPositiveInfinity(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToZero(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundCurrentDirection(Vector256<double> value) { throw null; }
        public static Vector256<sbyte> Set(sbyte e31, sbyte e30, sbyte e29, sbyte e28, sbyte e27, sbyte e26, sbyte e25, sbyte e24, sbyte e23, sbyte e22, sbyte e21, sbyte e20, sbyte e19, sbyte e18, sbyte e17, sbyte e16, sbyte e15, sbyte e14, sbyte e13, sbyte e12, sbyte e11, sbyte e10, sbyte e9, sbyte e8, sbyte e7, sbyte e6, sbyte e5, sbyte e4, sbyte e3, sbyte e2, sbyte e1, sbyte e0) { throw null; }
        public static Vector256<byte> Set(byte e31, byte e30, byte e29, byte e28, byte e27, byte e26, byte e25, byte e24, byte e23, byte e22, byte e21, byte e20, byte e19, byte e18, byte e17, byte e16, byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) { throw null; }
        public static Vector256<short> Set(short e15, short e14, short e13, short e12, short e11, short e10, short e9, short e8, short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { throw null; }
        public static Vector256<ushort> Set(ushort e15, ushort e14, ushort e13, ushort e12, ushort e11, ushort e10, ushort e9, ushort e8, ushort e7, ushort e6, ushort e5, ushort e4, ushort e3, ushort e2, ushort e1, ushort e0) { throw null; }
        public static Vector256<int> Set(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { throw null; }
        public static Vector256<uint> Set(uint e7, uint e6, uint e5, uint e4, uint e3, uint e2, uint e1, uint e0) { throw null; }
        public static Vector256<long> Set(long e3, long e2, long e1, long e0) { throw null; }
        public static Vector256<ulong> Set(ulong e3, ulong e2, ulong e1, ulong e0) { throw null; }
        public static Vector256<float> Set(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { throw null; }
        public static Vector256<double> Set(double e3, double e2, double e1, double e0) { throw null; }
        public static Vector256<T> Set1<T>(T value) where T : struct { throw null; }
        public static Vector256<T> SetHiLo<T>(Vector128<T> hi, Vector128<T> lo) where T : struct { throw null; }
        public static Vector256<T> SetZero<T>() where T : struct { throw null; }
        public static Vector256<float> Shuffle(Vector256<float> value, Vector256<float> right, byte control) { throw null; }
        public static Vector256<double> Shuffle(Vector256<double> value, Vector256<double> right, byte control) { throw null; }
        public static Vector256<float> Sqrt(Vector256<float> value) { throw null; }
        public static Vector256<double> Sqrt(Vector256<double> value) { throw null; }
        public static Vector256<U> StaticCast<T, U>(Vector256<T> value) where T : struct where U : struct { throw null; }
        public static unsafe void StoreAligned(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void StoreAligned(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void StoreAligned(short* address, Vector256<short> source) { throw null; }
        public static unsafe void StoreAligned(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void StoreAligned(int* address, Vector256<int> source) { throw null; }
        public static unsafe void StoreAligned(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void StoreAligned(long* address, Vector256<long> source) { throw null; }
        public static unsafe void StoreAligned(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void StoreAligned(float* address, Vector256<float> source) { throw null; }
        public static unsafe void StoreAligned(double* address, Vector256<double> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(short* address, Vector256<short> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(int* address, Vector256<int> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(long* address, Vector256<long> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(float* address, Vector256<float> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(double* address, Vector256<double> source) { throw null; }
        public static unsafe void Store(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void Store(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void Store(short* address, Vector256<short> source) { throw null; }
        public static unsafe void Store(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void Store(int* address, Vector256<int> source) { throw null; }
        public static unsafe void Store(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void Store(long* address, Vector256<long> source) { throw null; }
        public static unsafe void Store(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void Store(float* address, Vector256<float> source) { throw null; }
        public static unsafe void Store(double* address, Vector256<double> source) { throw null; }
        public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static bool TestC(Vector128<float> left, Vector128<float> right) { throw null; }       
        public static bool TestC(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestC<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static bool TestNotZAndNotC(Vector128<float> left, Vector128<float> right) { throw null; }       
        public static bool TestNotZAndNotC(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestNotZAndNotC<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static bool TestZ(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool TestZ(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestZ<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static Vector256<float> UnpackHigh(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> UnpackHigh(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> UnpackLow(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> UnpackLow(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Xor(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Xor(Vector256<double> left, Vector256<double> right) { throw null; }
        public static void ZeroAll() { throw null; }
        public static void ZeroUpper() { throw null; }
        public static Vector256<T> ZeroExtendToVector256<T>(Vector128<T> value) where T : struct { throw null; }
    }
    public static class Avx2
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector256<byte> Abs(Vector256<sbyte> value) { throw null; }
        public static Vector256<ushort> Abs(Vector256<short> value) { throw null; }
        public static Vector256<uint> Abs(Vector256<int> value) { throw null; }
        public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> AddSaturate(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> AddSaturate(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> AddSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> AddSaturate(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<sbyte> AlignRight(Vector256<sbyte> left, Vector256<sbyte> right, byte mask) { throw null; }
        public static Vector256<sbyte> And(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> And(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> And(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> And(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> And(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> And(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> And(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> And(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> AndNot(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> AndNot(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> AndNot(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> AndNot(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> AndNot(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> AndNot(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> AndNot(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> AndNot(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<byte> Average(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<ushort> Average(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector128<int> Blend(Vector128<int> left, Vector128<int> right, byte control) { throw null; }
        public static Vector128<uint> Blend(Vector128<uint> left, Vector128<uint> right, byte control) { throw null; }
        public static Vector256<short> Blend(Vector256<short> left, Vector256<short> right, byte control) { throw null; }
        public static Vector256<ushort> Blend(Vector256<ushort> left, Vector256<ushort> right, byte control) { throw null; }
        public static Vector256<int> Blend(Vector256<int> left, Vector256<int> right, byte control) { throw null; }
        public static Vector256<uint> Blend(Vector256<uint> left, Vector256<uint> right, byte control) { throw null; }
        public static Vector256<sbyte> BlendVariable(Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask) { throw null; }
        public static Vector256<byte> BlendVariable(Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask) { throw null; }
        public static Vector128<T> BroadcastElementToVector128<T>(Vector128<T> value) where T : struct { throw null; }
        public static Vector256<T> BroadcastElementToVector256<T>(Vector128<T> value) where T : struct { throw null; }
        public static unsafe Vector256<sbyte> BroadcastVector128ToVector256(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> BroadcastVector128ToVector256(byte* address) { throw null; }
        public static unsafe Vector256<short> BroadcastVector128ToVector256(short* address) { throw null; }
        public static unsafe Vector256<ushort> BroadcastVector128ToVector256(ushort* address) { throw null; }
        public static unsafe Vector256<int> BroadcastVector128ToVector256(int* address) { throw null; }
        public static unsafe Vector256<uint> BroadcastVector128ToVector256(uint* address) { throw null; }
        public static unsafe Vector256<long> BroadcastVector128ToVector256(long* address) { throw null; }
        public static unsafe Vector256<ulong> BroadcastVector128ToVector256(ulong* address) { throw null; }
        public static Vector256<sbyte> CompareEqual(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> CompareEqual(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> CompareEqual(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> CompareEqual(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> CompareEqual(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> CompareEqual(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> CompareEqual(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> CompareEqual(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> CompareGreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> CompareGreaterThan(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> CompareGreaterThan(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<long> CompareGreaterThan(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<short> ConvertToVector256Short(Vector128<sbyte> value) { throw null; }
        public static Vector256<ushort> ConvertToVector256UShort(Vector128<byte> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int(Vector128<sbyte> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int(Vector128<short> value) { throw null; }
        public static Vector256<uint> ConvertToVector256UInt(Vector128<byte> value) { throw null; }
        public static Vector256<uint> ConvertToVector256UInt(Vector128<ushort> value) { throw null; }
        public static Vector256<long> ConvertToVector256Long(Vector128<sbyte> value) { throw null; }
        public static Vector256<long> ConvertToVector256Long(Vector128<short> value) { throw null; }
        public static Vector256<long> ConvertToVector256Long(Vector128<int> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256ULong(Vector128<byte> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256ULong(Vector128<ushort> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256ULong(Vector128<uint> value) { throw null; }
        public static Vector128<sbyte> ExtractVector128(Vector256<sbyte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(sbyte* address, Vector256<sbyte> value, byte index) { throw null; }
        public static Vector128<byte> ExtractVector128(Vector256<byte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(byte* address, Vector256<byte> value, byte index) { throw null; }
        public static Vector128<short> ExtractVector128(Vector256<short> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(short* address, Vector256<short> value, byte index) { throw null; }
        public static Vector128<ushort> ExtractVector128(Vector256<ushort> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ushort* address, Vector256<ushort> value, byte index) { throw null; }
        public static Vector128<int> ExtractVector128(Vector256<int> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(int* address, Vector256<int> value, byte index) { throw null; }
        public static Vector128<uint> ExtractVector128(Vector256<uint> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(uint* address, Vector256<uint> value, byte index) { throw null; }
        public static Vector128<long> ExtractVector128(Vector256<long> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(long* address, Vector256<long> value, byte index) { throw null; }
        public static Vector128<ulong> ExtractVector128(Vector256<ulong> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ulong* address, Vector256<ulong> value, byte index) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherVector128(long* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherVector128(double* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherVector128(long* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherVector128(double* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector256<int> GatherVector256(int* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<uint> GatherVector256(uint* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherVector256(long* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherVector256(ulong* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector256<float> GatherVector256(float* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherVector256(double* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherVector256(long* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherVector256(ulong* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherVector256(double* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, byte scale) { throw null; }
        public static unsafe Vector256<int> GatherMaskVector256(Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, byte scale) { throw null; }
        public static unsafe Vector256<uint> GatherMaskVector256(Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector256<float> GatherMaskVector256(Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, byte scale) { throw null; }
        public static Vector256<short> HorizontalAdd(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> HorizontalAdd(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<short> HorizontalAddSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> HorizontalSubtract(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> HorizontalSubtract(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<short> HorizontalSubtractSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<sbyte> Insert(Vector256<sbyte> value, Vector128<sbyte> data, byte index) { throw null; }
        public static unsafe Vector256<sbyte> Insert(Vector256<sbyte> value, sbyte* address, byte index) { throw null; }
        public static Vector256<byte> Insert(Vector256<byte> value, Vector128<byte> data, byte index) { throw null; }
        public static unsafe Vector256<byte> Insert(Vector256<byte> value, byte* address, byte index) { throw null; }
        public static Vector256<short> Insert(Vector256<short> value, Vector128<short> data, byte index) { throw null; }
        public static unsafe Vector256<short> Insert(Vector256<short> value, short* address, byte index) { throw null; }
        public static Vector256<ushort> Insert(Vector256<ushort> value, Vector128<ushort> data, byte index) { throw null; }
        public static unsafe Vector256<ushort> Insert(Vector256<ushort> value, ushort* address, byte index) { throw null; }
        public static Vector256<int> Insert(Vector256<int> value, Vector128<int> data, byte index) { throw null; }
        public static unsafe Vector256<int> Insert(Vector256<int> value, int* address, byte index) { throw null; }
        public static Vector256<uint> Insert(Vector256<uint> value, Vector128<uint> data, byte index) { throw null; }
        public static unsafe Vector256<uint> Insert(Vector256<uint> value, uint* address, byte index) { throw null; }
        public static Vector256<long> Insert(Vector256<long> value, Vector128<long> data, byte index) { throw null; }
        public static unsafe Vector256<long> Insert(Vector256<long> value, long* address, byte index) { throw null; }
        public static Vector256<ulong> Insert(Vector256<ulong> value, Vector128<ulong> data, byte index) { throw null; }
        public static unsafe Vector256<ulong> Insert(Vector256<ulong> value, ulong* address, byte index) { throw null; }
        public static unsafe Vector128<int> MaskLoad(int* address, Vector128<int> mask) { throw null; }
        public static unsafe Vector128<uint> MaskLoad(uint* address, Vector128<uint> mask) { throw null; }
        public static unsafe Vector128<long> MaskLoad(long* address, Vector128<long> mask) { throw null; }
        public static unsafe Vector128<ulong> MaskLoad(ulong* address, Vector128<ulong> mask) { throw null; }
        public static unsafe Vector256<int> MaskLoad(int* address, Vector256<int> mask) { throw null; }
        public static unsafe Vector256<uint> MaskLoad(uint* address, Vector256<uint> mask) { throw null; }
        public static unsafe Vector256<long> MaskLoad(long* address, Vector256<long> mask) { throw null; }
        public static unsafe Vector256<ulong> MaskLoad(ulong* address, Vector256<ulong> mask) { throw null; }
        public static unsafe void MaskStore(int* address, Vector128<int> mask, Vector128<int> source) { throw null; }
        public static unsafe void MaskStore(uint* address, Vector128<uint> mask, Vector128<uint> source) { throw null; }
        public static unsafe void MaskStore(long* address, Vector128<long> mask, Vector128<long> source) { throw null; }
        public static unsafe void MaskStore(ulong* address, Vector128<ulong> mask, Vector128<ulong> source) { throw null; }
        public static unsafe void MaskStore(int* address, Vector256<int> mask, Vector256<int> source) { throw null; }
        public static unsafe void MaskStore(uint* address, Vector256<uint> mask, Vector256<uint> source) { throw null; }
        public static unsafe void MaskStore(long* address, Vector256<long> mask, Vector256<long> source) { throw null; }
        public static unsafe void MaskStore(ulong* address, Vector256<ulong> mask, Vector256<ulong> source) { throw null; }
        public static Vector256<int> MultiplyAddAdjacent(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> MultiplyAddAdjacent(Vector256<byte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Max(Vector256<byte> left, Vector256<short> right) { throw null; }
        public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static int MoveMask(Vector256<sbyte> value) { throw null; }
        public static int MoveMask(Vector256<byte> value) { throw null; }
        public static Vector256<ushort> MultipleSumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right, byte mask) { throw null; }
        public static Vector256<long> Multiply(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<ulong> Multiply(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<short> MultiplyHigh(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> MultiplyHigh(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<short> MultiplyHighRoundScale(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> MultiplyLow(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> MultiplyLow(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Or(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Or(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Or(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Or(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Or(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Or(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Or(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Or(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> PackSignedSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> PackSignedSaturate(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<byte> PackUnsignedSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> PackUnsignedSaturate(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Permute2x128(Vector256<sbyte> left, Vector256<sbyte> right, byte control) { throw null; }
        public static Vector256<byte> Permute2x128(Vector256<byte> left, Vector256<byte> right, byte control) { throw null; }
        public static Vector256<short> Permute2x128(Vector256<short> left, Vector256<short> right, byte control) { throw null; }
        public static Vector256<ushort> Permute2x128(Vector256<ushort> left, Vector256<ushort> right, byte control) { throw null; }
        public static Vector256<int> Permute2x128(Vector256<int> left, Vector256<int> right, byte control) { throw null; }
        public static Vector256<uint> Permute2x128(Vector256<uint> left, Vector256<uint> right, byte control) { throw null; }
        public static Vector256<long> Permute2x128(Vector256<long> left, Vector256<long> right, byte control) { throw null; }
        public static Vector256<ulong> Permute2x128(Vector256<ulong> left, Vector256<ulong> right, byte control) { throw null; }
        public static Vector256<long> Permute4x64(Vector256<long> value, byte control) { throw null; }
        public static Vector256<ulong> Permute4x64(Vector256<ulong> value, byte control) { throw null; }
        public static Vector256<double> Permute4x64(Vector256<double> value, byte control) { throw null; }
        public static Vector256<int> PermuteVar8x32(Vector256<int> left, Vector256<int> mask) { throw null; }
        public static Vector256<uint> PermuteVar8x32(Vector256<uint> left, Vector256<uint> mask) { throw null; }
        public static Vector256<float> PermuteVar8x32(Vector256<float> left, Vector256<float> mask) { throw null; }
        public static Vector256<short> ShiftLeftLogical(Vector256<short> value, byte count) { throw null; }
        public static Vector256<ushort> ShiftLeftLogical(Vector256<ushort> value, byte count) { throw null; }
        public static Vector256<int> ShiftLeftLogical(Vector256<int> value, byte count) { throw null; }
        public static Vector256<uint> ShiftLeftLogical(Vector256<uint> value, byte count) { throw null; }
        public static Vector256<long> ShiftLeftLogical(Vector256<long> value, byte count) { throw null; }
        public static Vector256<ulong> ShiftLeftLogical(Vector256<ulong> value, byte count) { throw null; }
        public static Vector256<sbyte> ShiftLeftLogical128BitLane(Vector256<sbyte> value, byte numBytes) { throw null; }
        public static Vector256<byte> ShiftLeftLogical128BitLane(Vector256<byte> value, byte numBytes) { throw null; }
        public static Vector256<short> ShiftLeftLogical128BitLane(Vector256<short> value, byte numBytes) { throw null; }
        public static Vector256<ushort> ShiftLeftLogical128BitLane(Vector256<ushort> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftLeftLogical128BitLane(Vector256<int> value, byte numBytes) { throw null; }
        public static Vector256<uint> ShiftLeftLogical128BitLane(Vector256<uint> value, byte numBytes) { throw null; }
        public static Vector256<long> ShiftLeftLogical128BitLane(Vector256<long> value, byte numBytes) { throw null; }
        public static Vector256<ulong> ShiftLeftLogical128BitLane(Vector256<ulong> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftLeftLogicalVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector256<uint> ShiftLeftLogicalVariable(Vector256<uint> value, Vector256<uint> count) { throw null; }
        public static Vector256<long> ShiftLeftLogicalVariable(Vector256<long> value, Vector256<ulong> count) { throw null; }
        public static Vector256<ulong> ShiftLeftLogicalVariable(Vector256<ulong> value, Vector256<ulong> count) { throw null; }
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightArithmeticVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector256<short> ShiftRightLogical(Vector256<short> value, byte count) { throw null; }
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightLogical(Vector256<int> value, byte count) { throw null; }
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, byte count) { throw null; }
        public static Vector256<long> ShiftRightLogical(Vector256<long> value, byte count) { throw null; }
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, byte count) { throw null; }
        public static Vector256<sbyte> ShiftRightLogical128BitLane(Vector256<sbyte> value, byte numBytes) { throw null; }
        public static Vector256<byte> ShiftRightLogical128BitLane(Vector256<byte> value, byte numBytes) { throw null; }
        public static Vector256<short> ShiftRightLogical128BitLane(Vector256<short> value, byte numBytes) { throw null; }
        public static Vector256<ushort> ShiftRightLogical128BitLane(Vector256<ushort> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftRightLogical128BitLane(Vector256<int> value, byte numBytes) { throw null; }
        public static Vector256<uint> ShiftRightLogical128BitLane(Vector256<uint> value, byte numBytes) { throw null; }
        public static Vector256<long> ShiftRightLogical128BitLane(Vector256<long> value, byte numBytes) { throw null; }
        public static Vector256<ulong> ShiftRightLogical128BitLane(Vector256<ulong> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftRightLogicalVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector256<uint> ShiftRightLogicalVariable(Vector256<uint> value, Vector256<uint> count) { throw null; }
        public static Vector256<long> ShiftRightLogicalVariable(Vector256<long> value, Vector256<ulong> count) { throw null; }
        public static Vector256<ulong> ShiftRightLogicalVariable(Vector256<ulong> value, Vector256<ulong> count) { throw null; }
        public static Vector256<sbyte> Shuffle(Vector256<sbyte> value, Vector256<sbyte> mask) { throw null; }
        public static Vector256<byte> Shuffle(Vector256<byte> value, Vector256<byte> mask) { throw null; }
        public static Vector256<int> Shuffle(Vector256<int> value, byte control) { throw null; }
        public static Vector256<uint> Shuffle(Vector256<uint> value, byte control) { throw null; }
        public static Vector256<short> ShuffleHigh(Vector256<short> value, byte control) { throw null; }
        public static Vector256<ushort> ShuffleHigh(Vector256<ushort> value, byte control) { throw null; }
        public static Vector256<short> ShuffleLow(Vector256<short> value, byte control) { throw null; }
        public static Vector256<ushort> ShuffleLow(Vector256<ushort> value, byte control) { throw null; }
        public static Vector256<sbyte> Sign(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> Sign(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> Sign(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> SubtractSaturate(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> SubtractSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<byte> SubtractSaturate(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<ushort> SubtractSaturate(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<ulong> SumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<sbyte> UnpackHigh(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> UnpackHigh(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> UnpackHigh(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> UnpackHigh(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> UnpackHigh(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> UnpackHigh(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> UnpackHigh(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> UnpackHigh(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> UnpackLow(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> UnpackLow(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> UnpackLow(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> UnpackLow(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> UnpackLow(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> UnpackLow(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> UnpackLow(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> UnpackLow(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> Xor(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Xor(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Xor(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Xor(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Xor(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Xor(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Xor(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Xor(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
    }
    public static class Bmi1
    {
        public static bool IsSupported { get { throw null; } }
        public static uint AndNot(uint left, uint right) { throw null; }
        public static ulong AndNot(ulong left, ulong right) { throw null; }
        public static uint BitFieldExtract(uint value, uint start, uint length) { throw null; }
        public static ulong BitFieldExtract(ulong value, ulong start, ulong length) { throw null; }
        public static uint BitFieldExtract(uint value, uint control) { throw null; }
        public static ulong BitFieldExtract(ulong value, ulong control) { throw null; }
        public static uint ExtractLowestSetBit(uint value) { throw null; }
        public static ulong ExtractLowestSetBit(ulong value) { throw null; }
        public static uint GetMaskUptoLowestSetBit(uint value) { throw null; }
        public static ulong GetMaskUptoLowestSetBit(ulong value) { throw null; }
        public static uint ResetLowestSetBit(uint value) { throw null; }
        public static ulong ResetLowestSetBit(ulong value) { throw null; }
        public static uint TrailingZeroCount(uint value) { throw null; }
        public static ulong TrailingZeroCount(ulong value) { throw null; }
    }
    public static class Bmi2
    {
        public static bool IsSupported { get { throw null; } }
        public static uint ZeroHighBits(uint value, uint index) { throw null; }
        public static ulong ZeroHighBits(ulong value, ulong index) { throw null; }
        public static unsafe uint MultiplyNoFlags(uint left, uint right, uint* high) { throw null; }
        public static unsafe ulong MultiplyNoFlags(ulong left, ulong right, ulong* high) { throw null; }
        public static uint ParallelBitDeposit(uint value, uint mask) { throw null; }
        public static ulong ParallelBitDeposit(ulong value, ulong mask) { throw null; }
        public static uint ParallelBitExtract(uint value, uint mask) { throw null; }
        public static ulong ParallelBitExtract(ulong value, ulong mask) { throw null; }    
    }
    public enum FloatComparisonMode : byte
    {
        EqualOrderedNonSignaling = 0,
        LessThanOrderedSignaling = 1,
        LessThanOrEqualOrderedSignaling = 2,
        UnorderedNonSignaling = 3,
        NotEqualUnorderedNonSignaling = 4,
        NotLessThanUnorderedSignaling = 5,
        NotLessThanOrEqualUnorderedSignaling = 6,
        OrderedNonSignaling = 7,
        EqualUnorderedNonSignaling = 8,
        NotGreaterThanOrEqualUnorderedSignaling = 9,
        NotGreaterThanUnorderedSignaling = 10,
        FalseOrderedNonSignaling = 11,
        NotEqualOrderedNonSignaling = 12,
        GreaterThanOrEqualOrderedSignaling = 13,
        GreaterThanOrderedSignaling = 14,
        TrueUnorderedNonSignaling = 15,
        EqualOrderedSignaling = 16,
        LessThanOrderedNonSignaling = 17,
        LessThanOrEqualOrderedNonSignaling = 18,
        UnorderedSignaling = 19,
        NotEqualUnorderedSignaling = 20,
        NotLessThanUnorderedNonSignaling = 21,
        NotLessThanOrEqualUnorderedNonSignaling = 22,
        OrderedSignaling = 23,
        EqualUnorderedSignaling = 24,
        NotGreaterThanOrEqualUnorderedNonSignaling = 25,
        NotGreaterThanUnorderedNonSignaling = 26,
        FalseOrderedSignaling = 27,
        NotEqualOrderedSignaling = 28,
        GreaterThanOrEqualOrderedNonSignaling = 29,
        GreaterThanOrderedNonSignaling = 30,
        TrueUnorderedSignaling = 31,
    }
    public enum StringComparisonMode : byte {
        EqualAny = 0x00,
        Ranges = 0x04,
        EqualEach = 0x08,
        EqualOrdered = 0x0c,
        NegativePolarity = 0x10,
        MaskedNegativePolarity = 0x30,
        LeastSignificant = 0x00,
        MostSignificant = 0x40,
    }
    public enum ResultsFlag : byte {
        CFlag = 0,
        NotCFlagAndNotZFlag = 1,
        OFlag = 2,
        SFlag = 3,
        ZFlag = 4,
    }
    public static class Fma
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<float> MultiplyAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplyAddSubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAddSubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAddSubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAddSubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplySubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplySubtractAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtractAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtractAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtractAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplyAddNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAddNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAddNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAddNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplySubtractNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtractNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtractNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtractNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
    }
    public static class Lzcnt
    {
        public static bool IsSupported { get { throw null; } }
        public static uint LeadingZeroCount(uint value) { throw null; }
        public static ulong LeadingZeroCount(ulong value) { throw null; }
    }
    public static class Pclmulqdq
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<long> CarryLessMultiply(Vector128<long> left, Vector128<long> right, byte control) { throw null; }
        public static Vector128<ulong> CarryLessMultiply(Vector128<ulong> left, Vector128<ulong> right, byte control) { throw null; }
    }
    public static class Popcnt
    {
        public static bool IsSupported { get { throw null; } }
        public static int PopCount(uint value) { throw null; }
        public static long PopCount(ulong value) { throw null; }
    }
    public static class Sse
    {
        public static bool IsSupported { get { return false; } }
        public static Vector128<float> Add(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> And(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> AndNot(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareGreaterThan(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareLessThan(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareNotEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareNotGreaterThan(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareNotGreaterThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareNotLessThan(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareNotLessThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareOrdered(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> CompareUnordered(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Divide(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static unsafe Vector128<float> Load(float* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<float> LoadAligned(float* address) { throw new NotImplementedException(); }
        public static Vector128<float> Max(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Min(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> MoveHighToLow(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> MoveLowToHigh(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Multiply(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Or(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Reciprocal(Vector128<float> value) { throw new NotImplementedException(); }
        public static Vector128<float> ReciprocalSquareRoot(Vector128<float> value) { throw new NotImplementedException(); }
        public static Vector128<float> Set(float e3, float e2, float e1, float e0) { throw new NotImplementedException(); }
        public static Vector128<float> Set1(float value) { throw new NotImplementedException(); }
        public static Vector128<float> SetZero() { throw new NotImplementedException(); }
        public static Vector128<U> StaticCast<T, U>(Vector128<T> value) where T : struct where U : struct { throw new NotImplementedException(); }
        public static Vector128<float> Shuffle(Vector128<float> left, Vector128<float> right, byte control) { throw new NotImplementedException(); }
        public static Vector128<float> Sqrt(Vector128<float> value) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(float* address, Vector128<float> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(float* address, Vector128<float> source) { throw new NotImplementedException(); }
        public static unsafe void Store(float* address, Vector128<float> source) { throw new NotImplementedException(); }
        public static Vector128<float> Subtract(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> UnpackHigh(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> UnpackLow(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
        public static Vector128<float> Xor(Vector128<float> left,  Vector128<float> right) { throw new NotImplementedException(); }
    }
    public static class Sse2
    {
        public static bool IsSupported { get { return false; } }
        public static Vector128<byte> Add(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Add(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Add(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> Add(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> Add(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> Add(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> Add(Vector128<byte> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> Add(Vector128<sbyte> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> Add(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<byte> AddSaturate(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<short> AddSaturate(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> AddSaturate(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<byte> And(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> And(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> And(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> And(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> And(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> And(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> And(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> And(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> And(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<byte> AndNot(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> AndNot(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> AndNot(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> AndNot(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> AndNot(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> AndNot(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> AndNot(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> AndNot(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> AndNot(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<byte> Average(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> Average(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> CompareEqual(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<byte> CompareEqual(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<short> CompareEqual(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> CompareEqual(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> CompareEqual(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> CompareEqual(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> CompareGreaterThan(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<int> CompareGreaterThan(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareGreaterThan(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> CompareLessThan(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<int> CompareLessThan(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareLessThan(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareLessThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareNotEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareNotGreaterThan(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareNotGreaterThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareNotLessThan(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareNotLessThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareOrdered(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<double> CompareUnordered(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<int> ConvertToInt(Vector128<float> value) { throw new NotImplementedException(); }
        public static Vector128<int> ConvertToInt(Vector128<double> value) { throw new NotImplementedException(); }
        public static Vector128<float> ConvertToFloat(Vector128<int> value) { throw new NotImplementedException(); }
        public static Vector128<float> ConvertToFloat(Vector128<double> value) { throw new NotImplementedException(); }
        public static Vector128<double> ConvertToDouble(Vector128<int> value) { throw new NotImplementedException(); }
        public static Vector128<double> ConvertToDouble(Vector128<float> value) { throw new NotImplementedException(); }
        public static Vector128<int> ConvertToIntWithTruncation(Vector128<float> value) { throw new NotImplementedException(); }
        public static Vector128<int> ConvertToIntWithTruncation(Vector128<double> value) { throw new NotImplementedException(); }
        public static Vector128<double> Divide(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static short ExtractShort<T>(Vector128<T> value,  byte index) where T : struct { throw new NotImplementedException(); }
        public static ushort ExtractUshort<T>(Vector128<T> value,  byte index) where T : struct { throw new NotImplementedException(); }
        public static Vector128<T> InsertShort<T>(Vector128<T> value,  short data, byte index) where T : struct { throw new NotImplementedException(); }
        public static Vector128<T> InsertUshort<T>(Vector128<T> value,  ushort data, byte index) where T : struct { throw new NotImplementedException(); }
        public static unsafe Vector128<sbyte> Load(sbyte* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<byte> Load(byte* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<short> Load(short* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<ushort> Load(ushort* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<int> Load(int* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<uint> Load(uint* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<long> Load(long* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<ulong> Load(ulong* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<double> Load(double* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<sbyte> LoadAligned(sbyte* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<byte> LoadAligned(byte* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<short> LoadAligned(short* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<ushort> LoadAligned(ushort* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<int> LoadAligned(int* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<uint> LoadAligned(uint* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<long> LoadAligned(long* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<ulong> LoadAligned(ulong* address) { throw new NotImplementedException(); }
        public static unsafe Vector128<double> LoadAligned(double* address) { throw new NotImplementedException(); }
        public static unsafe void MaskMove(Vector128<sbyte> source,  Vector128<sbyte> mask, sbyte* address) { throw new NotImplementedException(); }
        public static unsafe void MaskMove(Vector128<byte> source,  Vector128<byte> mask, byte* address) { throw new NotImplementedException(); }
        public static Vector128<byte> Max(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Max(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<double> Max(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<byte> Min(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Min(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<double> Min(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static int MoveMask(Vector128<sbyte> value) { throw new NotImplementedException(); }
        public static int MoveMask(Vector128<double> value) { throw new NotImplementedException(); }
        public static Vector128<ulong> Multiply(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<double> Multiply(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<short> MultiplyHi(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> MultiplyHi(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> MultiplyHorizontalAdd(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<short> MultiplyLow(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<byte> Or(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Or(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Or(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> Or(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> Or(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> Or(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> Or(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> Or(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> Or(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> PackSignedSaturate(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<short> PackSignedSaturate(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<byte> PackUnsignedSaturate(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Set(sbyte e15, sbyte e14, sbyte e13, sbyte e12, sbyte e11, sbyte e10, sbyte e9, sbyte e8, sbyte e7, sbyte e6, sbyte e5, sbyte e4, sbyte e3, sbyte e2, sbyte e1, sbyte e0) { throw new NotImplementedException(); }
        public static Vector128<byte> Set(byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) { throw new NotImplementedException(); }
        public static Vector128<short> Set(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { throw new NotImplementedException(); }
        public static Vector128<ushort> Set(ushort e7, ushort e6, ushort e5, ushort e4, ushort e3, ushort e2, ushort e1, ushort e0) { throw new NotImplementedException(); }
        public static Vector128<int> Set(int e3, int e2, int e1, int e0) { throw new NotImplementedException(); }
        public static Vector128<uint> Set(uint e3, uint e2, uint e1, uint e0) { throw new NotImplementedException(); }
        public static Vector128<long> Set(long e1, long e0) { throw new NotImplementedException(); }
        public static Vector128<ulong> Set(ulong e1, ulong e0) { throw new NotImplementedException(); }
        public static Vector128<double> Set(double e1, double e0) { throw new NotImplementedException(); }
        public static Vector128<byte> Set1(byte value) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Set1(sbyte value) { throw new NotImplementedException(); }
        public static Vector128<short> Set1(short value) { throw new NotImplementedException(); }
        public static Vector128<ushort> Set1(ushort value) { throw new NotImplementedException(); }
        public static Vector128<int> Set1(int value) { throw new NotImplementedException(); }
        public static Vector128<uint> Set1(uint value) { throw new NotImplementedException(); }
        public static Vector128<long> Set1(long value) { throw new NotImplementedException(); }
        public static Vector128<ulong> Set1(ulong value) { throw new NotImplementedException(); }
        public static Vector128<double> Set1(double value) { throw new NotImplementedException(); }
        public static Vector128<T> SetZero<T>() where T : struct { throw new NotImplementedException(); }
        public static Vector128<long> SumAbsoluteDifferences(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<int> Shuffle(Vector128<int> value, byte control) { throw new NotImplementedException(); }
        public static Vector128<uint> Shuffle(Vector128<uint> value,  byte control) { throw new NotImplementedException(); }
        public static Vector128<double> Shuffle(Vector128<double> left, Vector128<double> right, byte control) { throw new NotImplementedException(); }
        public static Vector128<short> ShuffleHigh(Vector128<short> value, byte control) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShuffleHigh(Vector128<ushort> value, byte control) { throw new NotImplementedException(); }
        public static Vector128<short> ShuffleLow(Vector128<short> value, byte control) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShuffleLow(Vector128<ushort> value, byte control) { throw new NotImplementedException(); }
        public static Vector128<short> ShiftLeftLogical(Vector128<short> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<int> ShiftLeftLogical(Vector128<int> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<long> ShiftLeftLogical(Vector128<long> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<sbyte> ShiftLeftLogical128BitLane(Vector128<sbyte> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<byte> ShiftLeftLogical128BitLane(Vector128<byte> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<short> ShiftLeftLogical128BitLane(Vector128<short> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShiftLeftLogical128BitLane(Vector128<ushort> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<int> ShiftLeftLogical128BitLane(Vector128<int> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<uint> ShiftLeftLogical128BitLane(Vector128<uint> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<long> ShiftLeftLogical128BitLane(Vector128<long> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<ulong> ShiftLeftLogical128BitLane(Vector128<ulong> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<short> ShiftRightLogical(Vector128<short> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<int> ShiftRightLogical(Vector128<int> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<long> ShiftRightLogical(Vector128<long> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, byte count) { throw new NotImplementedException(); }
        public static Vector128<sbyte> ShiftRightLogical128BitLane(Vector128<sbyte> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<byte> ShiftRightLogical128BitLane(Vector128<byte> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<short> ShiftRightLogical128BitLane(Vector128<short> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<ushort> ShiftRightLogical128BitLane(Vector128<ushort> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<int> ShiftRightLogical128BitLane(Vector128<int> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<uint> ShiftRightLogical128BitLane(Vector128<uint> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<long> ShiftRightLogical128BitLane(Vector128<long> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<ulong> ShiftRightLogical128BitLane(Vector128<ulong> value, byte numBytes) { throw new NotImplementedException(); }
        public static Vector128<double> Sqrt(Vector128<double> value) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(sbyte* address, Vector128<sbyte> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(byte* address, Vector128<byte> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(short* address, Vector128<short> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(ushort* address, Vector128<ushort> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(int* address, Vector128<int> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(uint* address, Vector128<uint> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(long* address, Vector128<long> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(ulong* address, Vector128<ulong> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAligned(double* address, Vector128<double> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(sbyte* address, Vector128<sbyte> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(byte* address, Vector128<byte> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(short* address, Vector128<short> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(ushort* address, Vector128<ushort> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(int* address, Vector128<int> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(uint* address, Vector128<uint> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(long* address, Vector128<long> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(ulong* address, Vector128<ulong> source) { throw new NotImplementedException(); }
        public static unsafe void StoreAlignedNonTemporal(double* address, Vector128<double> source) { throw new NotImplementedException(); }
        public static unsafe void Store(sbyte* address, Vector128<sbyte> source) { throw new NotImplementedException(); }
        public static unsafe void Store(byte* address, Vector128<byte> source) { throw new NotImplementedException(); }
        public static unsafe void Store(short* address, Vector128<short> source) { throw new NotImplementedException(); }
        public static unsafe void Store(ushort* address, Vector128<ushort> source) { throw new NotImplementedException(); }
        public static unsafe void Store(int* address, Vector128<int> source) { throw new NotImplementedException(); }
        public static unsafe void Store(uint* address, Vector128<uint> source) { throw new NotImplementedException(); }
        public static unsafe void Store(long* address, Vector128<long> source) { throw new NotImplementedException(); }
        public static unsafe void Store(ulong* address, Vector128<ulong> source) { throw new NotImplementedException(); }
        public static unsafe void Store(double* address, Vector128<double> source) { throw new NotImplementedException(); }
        public static unsafe void StoreHigh(double* address, Vector128<double> source) { throw new NotImplementedException(); }
        public static unsafe void StoreLow(long* address, Vector128<long> source) { throw new NotImplementedException(); }
        public static unsafe void StoreLow(ulong* address, Vector128<ulong> source) { throw new NotImplementedException(); }
        public static unsafe void StoreLow(double* address, Vector128<double> source) { throw new NotImplementedException(); }
        public static Vector128<byte> Subtract(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Subtract(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Subtract(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> Subtract(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> Subtract(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> Subtract(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> Subtract(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> Subtract(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> Subtract(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> SubtractSaturate(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<byte> SubtractSaturate(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> SubtractSaturate(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<byte> UnpackHigh(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> UnpackHigh(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> UnpackHigh(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> UnpackHigh(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> UnpackHigh(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> UnpackHigh(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> UnpackHigh(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> UnpackHigh(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> UnpackHigh(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<byte> UnpackLow(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> UnpackLow(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> UnpackLow(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> UnpackLow(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> UnpackLow(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> UnpackLow(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> UnpackLow(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> UnpackLow(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> UnpackLow(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
        public static Vector128<byte> Xor(Vector128<byte> left,  Vector128<byte> right) { throw new NotImplementedException(); }
        public static Vector128<sbyte> Xor(Vector128<sbyte> left,  Vector128<sbyte> right) { throw new NotImplementedException(); }
        public static Vector128<short> Xor(Vector128<short> left,  Vector128<short> right) { throw new NotImplementedException(); }
        public static Vector128<ushort> Xor(Vector128<ushort> left,  Vector128<ushort> right) { throw new NotImplementedException(); }
        public static Vector128<int> Xor(Vector128<int> left,  Vector128<int> right) { throw new NotImplementedException(); }
        public static Vector128<uint> Xor(Vector128<uint> left,  Vector128<uint> right) { throw new NotImplementedException(); }
        public static Vector128<long> Xor(Vector128<long> left,  Vector128<long> right) { throw new NotImplementedException(); }
        public static Vector128<ulong> Xor(Vector128<ulong> left,  Vector128<ulong> right) { throw new NotImplementedException(); }
        public static Vector128<double> Xor(Vector128<double> left,  Vector128<double> right) { throw new NotImplementedException(); }
    }
    public static class Sse3
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<float> AddSubtract(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> AddSubtract(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<float> HorizontalAdd(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> HorizontalAdd(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<float> HorizontalSubtract(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> HorizontalSubtract(Vector128<double> left, Vector128<double> right) { throw null; }
        public static unsafe Vector128<double> LoadAndDuplicate(double* address) { throw null; }
        public static unsafe Vector128<sbyte> LoadDqu(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadDqu(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadDqu(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadDqu(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadDqu(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadDqu(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadDqu(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadDqu(ulong* address) { throw null; }
        public static Vector128<double> MoveAndDuplicate(Vector128<double> source) { throw null; }
        public static Vector128<float> MoveHighAndDuplicate(Vector128<float> source) { throw null; }
        public static Vector128<float> MoveLowAndDuplicate(Vector128<float> source) { throw null; }
    }
    public static class Sse41
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<short> Blend(Vector128<short> left, Vector128<short> right, byte control) { throw null; }
        public static Vector128<ushort> Blend(Vector128<ushort> left, Vector128<ushort> right, byte control) { throw null; }
        public static Vector128<float> Blend(Vector128<float> left, Vector128<float> right, byte control) { throw null; }
        public static Vector128<double> Blend(Vector128<double> left, Vector128<double> right, byte control) { throw null; }
        public static Vector128<sbyte> BlendVariable(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask) { throw null; }
        public static Vector128<byte> BlendVariable(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask) { throw null; }
        public static Vector128<float> BlendVariable(Vector128<float> left, Vector128<float> right, Vector128<float> mask) { throw null; }
        public static Vector128<double> BlendVariable(Vector128<double> left, Vector128<double> right, Vector128<double> mask) { throw null; }
        public static Vector128<float> Ceiling(Vector128<float> value) { throw null; }
        public static Vector128<double> Ceiling(Vector128<double> value) { throw null; }
        public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right) { throw null; }
        public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static Vector128<short> ConvertToShort(Vector128<sbyte> value) { throw null; }
        public static Vector128<short> ConvertToShort(Vector128<byte> value) { throw null; }
        public static Vector128<int> ConvertToInt(Vector128<sbyte> value) { throw null; }
        public static Vector128<int> ConvertToInt(Vector128<byte> value) { throw null; }
        public static Vector128<int> ConvertToInt(Vector128<short> value) { throw null; }
        public static Vector128<int> ConvertToInt(Vector128<ushort> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<sbyte> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<byte> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<short> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<ushort> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<int> value) { throw null; }
        public static Vector128<long> ConvertToLong(Vector128<uint> value) { throw null; }
        public static sbyte ExtractSbyte<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static byte ExtractByte<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static int ExtractInt<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static uint ExtractUint<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static long ExtractLong<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static ulong ExtractUlong<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static float ExtractFloat<T>(Vector128<T> value, byte index) where T : struct { throw null; }
        public static Vector128<float> Floor(Vector128<float> value) { throw null; }
        public static Vector128<double> Floor(Vector128<double> value) { throw null; }
        public static Vector128<T> InsertSbyte<T>(Vector128<T> value, sbyte data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertByte<T>(Vector128<T> value, byte data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertInt<T>(Vector128<T> value, int data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertUint<T>(Vector128<T> value, uint data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertLong<T>(Vector128<T> value, long data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertUlong<T>(Vector128<T> value, ulong data, byte index) where T : struct { throw null; }
        public static Vector128<T> InsertFloat<T>(Vector128<T> value, float data, byte index) where T : struct { throw null; }
        public static Vector128<sbyte> Max(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<ushort> Max(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Max(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Max(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<sbyte> Min(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<ushort> Min(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Min(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Min(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<ushort> MinHorizontal(Vector128<ushort> value) { throw null; }
        public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right, byte mask) { throw null; }
        public static Vector128<long> Multiply(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<int> MultiplyLow(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<float> RoundToNearestInteger(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToZero(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundCurrentDirection(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToNearestInteger(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToZero(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundCurrentDirection(Vector128<double> value) { throw null; }
        public static unsafe Vector128<sbyte> LoadAlignedNonTemporal(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadAlignedNonTemporal(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadAlignedNonTemporal(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadAlignedNonTemporal(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadAlignedNonTemporal(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadAlignedNonTemporal(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadAlignedNonTemporal(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadAlignedNonTemporal(ulong* address) { throw null; }
        public static bool TestAllOnes(Vector128<sbyte> value) { throw null; }
        public static bool TestAllOnes(Vector128<byte> value) { throw null; }
        public static bool TestAllOnes(Vector128<short> value) { throw null; }
        public static bool TestAllOnes(Vector128<ushort> value) { throw null; }
        public static bool TestAllOnes(Vector128<int> value) { throw null; }
        public static bool TestAllOnes(Vector128<uint> value) { throw null; }
        public static bool TestAllOnes(Vector128<long> value) { throw null; }
        public static bool TestAllOnes(Vector128<ulong> value) { throw null; }
        public static bool TestAllZeros(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestAllZeros(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestAllZeros(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestAllZeros(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestAllZeros(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestAllZeros(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestAllZeros(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestAllZeros(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestC(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestC(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestC(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestC(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestC(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestC(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestC(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestC(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestZ(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestZ(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestZ(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestZ(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestZ(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestZ(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestZ(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
    }
    public static class Sse42
    {
        public static bool IsSupported { get { throw null; } }
        public static bool CompareImplicitLength(Vector128<sbyte> left, Vector128<sbyte> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<byte> left, Vector128<byte> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<short> left, Vector128<short> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<ushort> left, Vector128<ushort> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthBitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthBitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthBitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthBitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right) { throw null; }
        public static uint Crc32(uint crc, byte data) { throw null; }
        public static uint Crc32(uint crc, ushort data) { throw null; }
        public static uint Crc32(uint crc, uint data) { throw null; }
        public static ulong Crc32(ulong crc, ulong data) { throw null; }
    }
    public static class Ssse3
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<byte> Abs(Vector128<sbyte> value) { throw null; }
        public static Vector128<ushort> Abs(Vector128<short> value) { throw null; }
        public static Vector128<uint> Abs(Vector128<int> value) { throw null; }
        public static Vector128<sbyte> AlignRight(Vector128<sbyte> left, Vector128<sbyte> right, byte mask) { throw null; }
        public static Vector128<short> HorizontalAdd(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> HorizontalAdd(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<short> HorizontalAddSaturate(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<short> HorizontalSubtract(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> HorizontalSubtract(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<short> HorizontalSubtractSaturate(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<short> MultiplyAddAdjacent(Vector128<byte> left, Vector128<sbyte> right) { throw null; }
        public static Vector128<short> MultiplyHighRoundScale(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<sbyte> Shuffle(Vector128<sbyte> value, Vector128<sbyte> mask) { throw null; }
        public static Vector128<sbyte> Sign(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Sign(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> Sign(Vector128<int> left, Vector128<int> right) { throw null; }
    }
}
